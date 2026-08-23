using System.ComponentModel.DataAnnotations;

namespace FundooNotesApp.ModelLayer.Dtos.Request
{
    // data client sends to reset password
    public class ResetPasswordRequestDto
    {
        [Required(ErrorMessage = "Token is required")]
        public string Token { get; set; }

        [Required(ErrorMessage = "New password is required")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 50 characters")]
        public string NewPassword { get; set; }
    }
}