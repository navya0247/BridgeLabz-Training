using FundooNotesApp.ModelLayer.Dtos.Request;
using FundooNotesApp.ModelLayer.Entities;
using FundooNotesApp.ModelLayer.Exceptions;
using FundooNotesApp.BusinessLayer.Interface;
using FundooNotesApp.BusinessLayer.Helper;
using FundooNotesApp.RepositoryLayer.Interface;

namespace FundooNotesApp.BusinessLayer.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly PasswordHasher _passwordHasher;
        private readonly JwtTokenHelper _jwtTokenHelper;
        private readonly RedisCacheHelper _cache;

        // repository and helpers injected here
        public UserService(IUserRepository repository, PasswordHasher passwordHasher, JwtTokenHelper jwtTokenHelper, RedisCacheHelper cache)
        {
            _repository = repository;
            _passwordHasher = passwordHasher;
            _jwtTokenHelper = jwtTokenHelper;
            _cache = cache;
        }

        public string Register(RegisterRequestDto registerRequestDto)
        {
            // check duplicate email
            var existing = _repository.GetUserByEmail(registerRequestDto.Email);
            if (existing != null)
                throw new UserAlreadyExistsException("Email already registered");

            // hashing happens here, bcrypt generates salt internally
            string hashedPassword = _passwordHasher.HashPassword(registerRequestDto.Password);

            UserEntity user = new UserEntity
            {
                FirstName = registerRequestDto.FirstName,
                LastName = registerRequestDto.LastName,
                Email = registerRequestDto.Email,
                PasswordHash = hashedPassword
            };

            _repository.AddUser(user);
            return "User registered successfully";
        }

        public string Login(LoginRequestDto loginRequestDto)
        {
            var user = _repository.GetUserByEmail(loginRequestDto.Email);
            if (user == null)
                throw new UserNotFoundException("User not found");

            // verify password against stored hash
            bool isValid = _passwordHasher.VerifyPassword(loginRequestDto.Password, user.PasswordHash);
            if (!isValid)
                throw new InvalidCredentialsException("Invalid email or password");

            string token = _jwtTokenHelper.GenerateToken(user.UserId, user.Email);

            // cache token against userId, expires in 2 hours matching jwt expiry
            _cache.SetToken($"user_token:{user.UserId}", token, TimeSpan.FromHours(2));

            return token;
        }

        public string Logout(int userId)
        {
            // removes cached token so it is rejected on future requests
            _cache.RemoveToken($"user_token:{userId}");
            return "Logged out successfully";
        }

        public string ForgotPassword(ForgotPasswordRequestDto forgotPasswordRequestDto)
        {
            var user = _repository.GetUserByEmail(forgotPasswordRequestDto.Email);
            if (user == null)
                throw new UserNotFoundException("User not found");

            // generate reset token and set expiry, 30 minutes
            user.ResetToken = Guid.NewGuid().ToString();
            user.ResetTokenExpiry = DateTime.UtcNow.AddMinutes(30);

            _repository.UpdateUser(user);
            return user.ResetToken;
        }

        public string ResetPassword(ResetPasswordRequestDto resetPasswordRequestDto)
        {
            var user = _repository.GetUserByResetToken(resetPasswordRequestDto.Token);
            if (user == null || user.ResetTokenExpiry == null || user.ResetTokenExpiry < DateTime.UtcNow)
                throw new InvalidCredentialsException("Reset link is invalid or has expired");

            // hash new password before saving
            user.PasswordHash = _passwordHasher.HashPassword(resetPasswordRequestDto.NewPassword);
            user.ResetToken = null;
            user.ResetTokenExpiry = null;

            _repository.UpdateUser(user);
            return "Password has been reset successfully";
        }
    }
}