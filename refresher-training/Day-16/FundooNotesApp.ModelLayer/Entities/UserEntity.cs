using System.ComponentModel.DataAnnotations;

namespace FundooNotesApp.ModelLayer.Entities
{
    // db table structure
    public class UserEntity
    {
        [Key]
        public int UserId { get; set; }

        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [Required, MaxLength(100)]
        public string Email { get; set; }

        [Required, MaxLength(256)]
        public string PasswordHash { get; set; }

        [MaxLength(100)]
        public string? ResetToken { get; set; }

        public DateTime? ResetTokenExpiry { get; set; }
    }
}