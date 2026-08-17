namespace ModelLayer.Exceptions
{
    // thrown when user not found for given email
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException(string message) : base(message) { }
    }
}