using System.ComponentModel.DataAnnotations;

namespace FundooNotesApp.ModelLayer.Models
{
    // plain model passed from repo to business layer, no password here
    public class UserModel
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "FirstName is required")]
        [StringLength(20, ErrorMessage = "FirstName must be at most 20 characters")]
        public string FirstName { get; set; }

        [StringLength(20, ErrorMessage = "LastName must be at most 20 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
    }
}