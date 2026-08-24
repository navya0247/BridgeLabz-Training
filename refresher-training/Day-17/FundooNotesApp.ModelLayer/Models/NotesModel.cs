namespace FundooNotesApp.ModelLayer.Models
{
    // plain model passed from repo to business layer
    public class NotesModel
    {
        public long NoteId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Pin { get; set; }
        public bool Archive { get; set; }
        public bool Trash { get; set; }
    }
}