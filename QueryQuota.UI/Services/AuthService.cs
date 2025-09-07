using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using QueryQuota.UI.DTOs;
using System.Net.Http.Headers;
using System.Text.Json;

namespace QueryQuota.UI.Services
{
    
    public class AuthService
    {
        private readonly HttpClient _httpClient;
        private readonly ProtectedSessionStorage _sessionStorage;

        private const string TokenKey = "authToken";
        private const string EmailKey = "userEmail";

        public string? Token { get; private set; }
        public string? UserEmail { get; private set; }
        public bool IsLoggedIn => !string.IsNullOrEmpty(Token);

        public event Action? OnAuthStateChanged;

        public AuthService(HttpClient httpClient, ProtectedSessionStorage sessionStorage)
        {
            _httpClient = httpClient;
            _sessionStorage = sessionStorage;
        }

        public async Task InitializeAsync()
        {
            var tokenResult = await _sessionStorage.GetAsync<string>(TokenKey);
            var emailResult = await _sessionStorage.GetAsync<string>(EmailKey);

            Token = tokenResult.Value;
            UserEmail = emailResult.Value;

            if (IsLoggedIn)
            {
                SetAuthorizationHeader(Token!);
                OnAuthStateChanged?.Invoke();
            }
        }

        private void SetAuthorizationHeader(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        public async Task<AuthenticationResponseDTO> LoginAsync(UserForAuthenticationDTO user)
        {
            var response = await _httpClient.PostAsJsonAsync("api/account/authentication", user);

            if (!response.IsSuccessStatusCode)
            {
                return new AuthenticationResponseDTO
                {
                    IsAuthenticationSuccessful = false,
                    ErrorMessage = "Yanlış kullanıcı adı ya da şifre"
                };
            }

            var result = await response.Content.ReadFromJsonAsync<AuthenticationResponseDTO>(
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (result != null && result.IsAuthenticationSuccessful && !string.IsNullOrEmpty(result.Token))
            {
                Token = result.Token;
                UserEmail = user.Email;

                SetAuthorizationHeader(Token);

                await _sessionStorage.SetAsync(TokenKey, Token);
                await _sessionStorage.SetAsync(EmailKey, UserEmail);

                OnAuthStateChanged?.Invoke();
            }

            return result ?? new AuthenticationResponseDTO
            {
                IsAuthenticationSuccessful = false,
                ErrorMessage = "Unknown error"
            };
        }

        public async Task LogoutAsync()
        {
            Token = null;
            UserEmail = null;

            _httpClient.DefaultRequestHeaders.Authorization = null;
            await _sessionStorage.DeleteAsync(TokenKey);
            await _sessionStorage.DeleteAsync(EmailKey);

            OnAuthStateChanged?.Invoke();
        }

        public async Task<AuthenticationResponseDTO> RegisterAsync(UserForRegistrationDTO user)
        {
            var response = await _httpClient.PostAsJsonAsync("api/account/register", user);

            if (!response.IsSuccessStatusCode)
            {
                return new AuthenticationResponseDTO
                {
                    IsAuthenticationSuccessful = false,
                    ErrorMessage = "Kayıt Başarısız"
                };
            }

            var result = await response.Content.ReadFromJsonAsync<AuthenticationResponseDTO>(
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return result ?? new AuthenticationResponseDTO
            {
                IsAuthenticationSuccessful = false,
                ErrorMessage = "Unknown error"
            };
        }
    }
}