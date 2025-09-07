namespace QueryQuota.UI.DTOs
{
    public class AuthenticationResponseDTO
    {
        public bool IsAuthenticationSuccessful { get; set; }
        public string? ErrorMessage { get; set; }
        public string? Token { get; set; }
    }
}

