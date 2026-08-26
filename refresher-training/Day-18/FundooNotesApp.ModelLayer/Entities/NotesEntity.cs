using System.ComponentModel.DataAnnotations;

namespace FundooNotesApp.ModelLayer.Entities
{
    // db table structure for notes
    public class NotesEntity
    {
        [Key]
        public long NoteId { get; set; }

        [Required, MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;

        public DateTime? Reminder { get; set; }

        [MaxLength(20)]
        public string Backgroundcolor { get; set; } = string.Empty;

        [MaxLength(200)]
        public string Image { get; set; } = string.Empty;

        public bool Pin { get; set; }
        public bool Archive { get; set; }
        public bool Trash { get; set; }

        // tracks whether a notification was already sent for this reminder
        public bool Notified { get; set; }

        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }

        // links note to the user who owns it
        public int UserId { get; set; }
    }
}