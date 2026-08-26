namespace FundooNotesApp.ModelLayer.Dtos.Response
{
    // data sent back to client for a notification
    public class NotificationResponseDto
    {
        public long NotificationId { get; set; }
        public long NoteId { get; set; }
        public string Message { get; set; } = string.Empty;
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}