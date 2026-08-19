namespace FundooNotesApp.ModelLayer.Dtos.Response
{
    // generic wrapper used across all apis
    public class ApiResponseDto<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T? Data { get; set; }
    }
}