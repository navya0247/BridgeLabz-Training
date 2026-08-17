using ModelLayer.Dtos;
using ModelLayer.Entities;
using ModelLayer.Exceptions;
using BusinessLayer.Interface;
using BusinessLayer.Helper;
using RepositoryLayer.Interface;
using BCrypt.Net;

namespace BusinessLayer.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly JwtTokenHelper _jwtTokenHelper;

        // repository and jwt helper injected here
        public UserService(IUserRepository repository, JwtTokenHelper jwtTokenHelper)
        {
            _repository = repository;
            _jwtTokenHelper = jwtTokenHelper;
        }

        public string Register(RegisterDto registerDto)
        {
            // check if email already exists
            var existingUser = _repository.GetUserByEmail(registerDto.Email);
            if (existingUser != null)
                throw new UserAlreadyExistsException("Email already registered");

            // hash password with salt using bcrypt
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(registerDto.Password);

            User user = new User
            {
                Name = registerDto.Name,
                Email = registerDto.Email,
                Password = hashedPassword
            };

            _repository.AddUser(user);
            return "User registered successfully";
        }

        public string Login(LoginDto loginDto)
        {
            var user = _repository.GetUserByEmail(loginDto.Email);
            if (user == null)
                throw new UserNotFoundException("User not found");

            // verify password against stored hash
            bool isValid = BCrypt.Net.BCrypt.Verify(loginDto.Password, user.Password);
            if (!isValid)
                throw new InvalidCredentialsException("Invalid email or password");

            // generate jwt token on successful login
            return _jwtTokenHelper.GenerateToken(user);
        }

        public string ForgotPassword(ForgotPasswordDto forgotPasswordDto)
        {
            // empty for now, will implement later
            return "Forgot password ";
        }
    }
}