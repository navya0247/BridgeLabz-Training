using FundooNotesApp.ModelLayer.Dtos.Request;

namespace FundooNotesApp.BusinessLayer.Interface
{
    public interface IUserService
    {
        string Register(RegisterRequestDto registerRequestDto);
        string Login(LoginRequestDto loginRequestDto);
        string ForgotPassword(ForgotPasswordRequestDto forgotPasswordRequestDto);
        string ResetPassword(ResetPasswordRequestDto resetPasswordRequestDto);
        string Logout(int userId);
    }
}