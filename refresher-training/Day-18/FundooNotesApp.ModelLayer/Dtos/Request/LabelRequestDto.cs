using System.ComponentModel.DataAnnotations;

namespace FundooNotesApp.ModelLayer.Dtos.Request
{
    // data client sends to create or edit a label
    public class LabelRequestDto
    {
        [Required(ErrorMessage = "Label name is required")]
        [MaxLength(50, ErrorMessage = "Label name must be at most 50 characters")]
        public string LabelName { get; set; } = string.Empty;

        [Required(ErrorMessage = "NoteId is required")]
        public int NoteId { get; set; }
    }
}