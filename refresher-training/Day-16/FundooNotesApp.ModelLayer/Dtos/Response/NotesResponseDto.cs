namespace FundooNotesApp.ModelLayer.Dtos.Response
{
    // data sent back to client for a note
    public class NotesResponseDto
    {
        public long NoteId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Pin { get; set; }
        public bool Archive { get; set; }
        public bool Trash { get; set; }
    }
}