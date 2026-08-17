namespace ModelLayer.Dtos
{
    // data client sends for login
    public class LoginDto
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}