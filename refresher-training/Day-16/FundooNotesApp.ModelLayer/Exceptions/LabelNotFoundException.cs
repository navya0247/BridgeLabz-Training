namespace FundooNotesApp.ModelLayer.Exceptions
{
    // thrown when label not found or user does not own it
    public class LabelNotFoundException : Exception
    {
        public LabelNotFoundException(string message) : base(message) { }
    }
}