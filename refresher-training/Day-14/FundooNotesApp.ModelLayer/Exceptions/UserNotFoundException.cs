namespace FundooNotesApp.ModelLayer.Exceptions
{
    // thrown when user not found
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException(string message) : base(message) { }
    }
}