namespace FundooNotesApp.ModelLayer.Exceptions
{
    // thrown when note not found or user does not own it
    public class NoteNotFoundException : Exception
    {
        public NoteNotFoundException(string message) : base(message) { }
    }
}