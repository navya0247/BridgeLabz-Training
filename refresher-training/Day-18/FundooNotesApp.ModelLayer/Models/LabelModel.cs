namespace FundooNotesApp.ModelLayer.Models
{
    
    public class LabelModel
    {
        public int LabelId { get; set; }
        public string LabelName { get; set; } = string.Empty;
        public int NoteId { get; set; }
    }
}