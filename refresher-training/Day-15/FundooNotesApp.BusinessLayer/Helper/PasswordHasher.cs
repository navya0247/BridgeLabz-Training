namespace FundooNotesApp.BusinessLayer.Helper
{
    public class PasswordHasher
    {
        // hashes password, bcrypt auto generates and embeds salt
        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        // verifies password against stored hash
        public bool VerifyPassword(string password, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(password, hash);
        }
    }
}