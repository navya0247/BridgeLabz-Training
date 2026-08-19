namespace FundooNotesApp.ModelLayer.Dtos.Response
{
    // data sent back after registration
    public class RegisterResponseDto
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
    }
}