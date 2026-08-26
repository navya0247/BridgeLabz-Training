using Microsoft.EntityFrameworkCore;
using FundooNotesApp.BusinessLayer.Service;
using FundooNotesApp.BusinessLayer.Helper;
using FundooNotesApp.ModelLayer.Dtos.Request;
using FundooNotesApp.ModelLayer.Exceptions;
using FundooNotesApp.RepositoryLayer.Context;
using FundooNotesApp.RepositoryLayer.Service;


namespace FundooNotesApp.Tests
{
    [TestClass]
    public class UserTests
    {

        private AppDbContext GetInMemoryContext()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            return new AppDbContext(options);
        }

        // builds UserService 
        private UserService GetUserService(AppDbContext context)
        {
            var userRepository = new UserRepository(context);
            var passwordHasher = new PasswordHasher();
            var jwtHelper = new JwtTokenHelper("TestSecretKeyForUnitTesting123456!");
            var cacheHelper = new RedisCacheHelper("localhost:6379");
            return new UserService(userRepository, passwordHasher, jwtHelper, cacheHelper);
        }

        [TestMethod]
        public void Register_ShouldSucceed_WhenEmailIsNew()
        {
            var userService = GetUserService(GetInMemoryContext());

            var registerDto = new RegisterRequestDto
            {
                FirstName = "New",
                LastName = "User",
                Email = "new@example.com",
                Password = "password123"
            };

            string result = userService.Register(registerDto);

            Assert.AreEqual("User registered successfully", result);
        }

        [TestMethod]
        public void Register_ShouldThrowException_WhenEmailAlreadyExists()
        {
            var userService = GetUserService(GetInMemoryContext());

            var registerDto = new RegisterRequestDto
            {
                FirstName = "Test",
                LastName = "User",
                Email = "duplicate@example.com",
                Password = "password123"
            };
            userService.Register(registerDto);

            // registering the same email again should throw
            try
            {
                userService.Register(registerDto);
                Assert.Fail("Expected UserAlreadyExistsException was not thrown");
            }
            catch (UserAlreadyExistsException) { }
        }

        [TestMethod]
        public void Login_ShouldReturnToken_WhenCredentialsAreCorrect()
        {
            var userService = GetUserService(GetInMemoryContext());

            userService.Register(new RegisterRequestDto
            {
                FirstName = "Test",
                LastName = "User",
                Email = "login@example.com",
                Password = "password123"
            });

            var loginDto = new LoginRequestDto { Email = "login@example.com", Password = "password123" };
            string token = userService.Login(loginDto);

            // token should not be empty on successful login
            Assert.IsFalse(string.IsNullOrEmpty(token));
        }

        [TestMethod]
        public void Login_ShouldThrowException_WhenPasswordIsWrong()
        {
            var userService = GetUserService(GetInMemoryContext());

            userService.Register(new RegisterRequestDto
            {
                FirstName = "Test",
                LastName = "User",
                Email = "login2@example.com",
                Password = "correctPassword"
            });

            var loginDto = new LoginRequestDto { Email = "login2@example.com", Password = "wrongPassword" };

            try
            {
                userService.Login(loginDto);
                Assert.Fail("Expected InvalidCredentialsException was not thrown");
            }
            catch (InvalidCredentialsException) { }
        }

        [TestMethod]
        public void Login_ShouldThrowException_WhenUserDoesNotExist()
        {
            var userService = GetUserService(GetInMemoryContext());

            var loginDto = new LoginRequestDto { Email = "doesnotexist@example.com", Password = "anyPassword" };

            try
            {
                userService.Login(loginDto);
                Assert.Fail("Expected UserNotFoundException was not thrown");
            }
            catch (UserNotFoundException) { }
        }

        [TestMethod]
        public void ForgotPassword_ShouldReturnToken_WhenEmailExists()
        {
            var userService = GetUserService(GetInMemoryContext());

            userService.Register(new RegisterRequestDto
            {
                FirstName = "Test",
                LastName = "User",
                Email = "forgot@example.com",
                Password = "password123"
            });

            string resetToken = userService.ForgotPassword(new ForgotPasswordRequestDto { Email = "forgot@example.com" });

            Assert.IsFalse(string.IsNullOrEmpty(resetToken));
        }

        [TestMethod]
        public void ForgotPassword_ShouldThrowException_WhenEmailNotFound()
        {
            var userService = GetUserService(GetInMemoryContext());

            try
            {
                userService.ForgotPassword(new ForgotPasswordRequestDto { Email = "notregistered@example.com" });
                Assert.Fail("Expected UserNotFoundException was not thrown");
            }
            catch (UserNotFoundException) { }
        }

        [TestMethod]
        public void ResetPassword_ShouldSucceed_WhenTokenIsValid()
        {
            var userService = GetUserService(GetInMemoryContext());

            userService.Register(new RegisterRequestDto
            {
                FirstName = "Test",
                LastName = "User",
                Email = "reset@example.com",
                Password = "oldPassword123"
            });
            string resetToken = userService.ForgotPassword(new ForgotPasswordRequestDto { Email = "reset@example.com" });

            string result = userService.ResetPassword(new ResetPasswordRequestDto { Token = resetToken, NewPassword = "newPassword456" });

            Assert.AreEqual("Password has been reset successfully", result);

            // confirm login works with the new password now
            var loginDto = new LoginRequestDto { Email = "reset@example.com", Password = "newPassword456" };
            string token = userService.Login(loginDto);
            Assert.IsFalse(string.IsNullOrEmpty(token));
        }

        [TestMethod]
        public void ResetPassword_ShouldThrowException_WhenTokenIsInvalid()
        {
            var userService = GetUserService(GetInMemoryContext());

            try
            {
                userService.ResetPassword(new ResetPasswordRequestDto { Token = "fake-invalid-token", NewPassword = "newPassword456" });
                Assert.Fail("Expected InvalidCredentialsException was not thrown");
            }
            catch (InvalidCredentialsException) { }
        }
    }
}