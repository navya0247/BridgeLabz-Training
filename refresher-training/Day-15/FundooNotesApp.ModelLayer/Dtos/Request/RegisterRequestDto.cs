using System.ComponentModel.DataAnnotations;

namespace FundooNotesApp.ModelLayer.Dtos.Request
{
    // data client sends to register
    public class RegisterRequestDto
    {
        [Required(ErrorMessage = "FirstName is required")]
        [StringLength(20, ErrorMessage = "FirstName must be at most 20 characters")]
        public string FirstName { get; set; }

        [StringLength(20, ErrorMessage = "LastName must be at most 20 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [StringLength(100, ErrorMessage = "Email must be at most 100 characters")]
        [RegularExpression(@"^[a-zA-Z0-9_.%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email format")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 50 characters")]
        public string Password { get; set; }
    }
}