namespace ModelLayer.Exceptions
{
    // thrown when login email or password is wrong
    public class InvalidCredentialsException : Exception
    {
        public InvalidCredentialsException(string message) : base(message) { }
    }
}