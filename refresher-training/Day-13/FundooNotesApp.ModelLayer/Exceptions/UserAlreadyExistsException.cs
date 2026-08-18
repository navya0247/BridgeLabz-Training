namespace FundooNotesApp.ModelLayer.Exceptions
{
    // thrown when email already registered
    public class UserAlreadyExistsException : Exception
    {
        public UserAlreadyExistsException(string message) : base(message) { }
    }
}