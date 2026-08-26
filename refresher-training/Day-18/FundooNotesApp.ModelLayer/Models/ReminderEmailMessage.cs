namespace FundooNotesApp.ModelLayer.Models
{
    // data passed through the queue
    public class ReminderEmailMessage
    {
        public string ToEmail { get; set; } = string.Empty;
        public string NoteTitle { get; set; } = string.Empty;
    }
}