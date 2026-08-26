using System.ComponentModel.DataAnnotations;

namespace FundooNotesApp.ModelLayer.Entities
{
    // db table structure for notifications
    public class NotificationEntity
    {
        [Key]
        public long NotificationId { get; set; }

        public long NoteId { get; set; }
        public int UserId { get; set; }

        [MaxLength(200)]
        public string Message { get; set; } = string.Empty;

        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}