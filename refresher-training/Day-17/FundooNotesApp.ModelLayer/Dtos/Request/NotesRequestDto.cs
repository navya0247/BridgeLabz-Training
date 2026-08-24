using System.ComponentModel.DataAnnotations;

namespace FundooNotesApp.ModelLayer.Dtos.Request
{
    // data client sends to create a note
    public class NotesRequestDto
    {
        [Required(ErrorMessage = "Title is required")]
        [StringLength(100, ErrorMessage = "Title must be at most 100 characters")]
        public string Title { get; set; }

        [StringLength(500, ErrorMessage = "Description must be at most 500 characters")]
        public string Description { get; set; }

        public DateTime? Reminder { get; set; }

        [StringLength(20, ErrorMessage = "Backgroundcolor must be at most 20 characters")]
        public string Backgroundcolor { get; set; }
    }
}