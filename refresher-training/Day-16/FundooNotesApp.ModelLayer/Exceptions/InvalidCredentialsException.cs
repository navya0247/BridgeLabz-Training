namespace FundooNotesApp.ModelLayer.Exceptions
{
    // thrown when password wrong or reset link invalid
    public class InvalidCredentialsException : Exception
    {
        public InvalidCredentialsException(string message) : base(message) { }
    }
}