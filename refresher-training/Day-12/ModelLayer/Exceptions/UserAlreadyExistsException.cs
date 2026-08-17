namespace ModelLayer.Exceptions
{
    // thrown when email is already registered
    public class UserAlreadyExistsException : Exception
    {
        public UserAlreadyExistsException(string message) : base(message) { }
    }
}