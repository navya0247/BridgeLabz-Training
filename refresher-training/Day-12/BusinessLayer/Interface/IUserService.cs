using ModelLayer.Dtos;

namespace BusinessLayer.Interface
{
    public interface IUserService
    {
        // registers new user, returns success message
        string Register(RegisterDto registerDto);

        // validates login, returns jwt token
        string Login(LoginDto loginDto);

        // forgot password, empty for now
        string ForgotPassword(ForgotPasswordDto forgotPasswordDto);
    }
}