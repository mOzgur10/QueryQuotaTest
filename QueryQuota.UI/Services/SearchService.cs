using System.Text.Json;
using QueryQuota.UI.DTOs;
using static System.Net.WebRequestMethods;

namespace QueryQuota.UI.Services
{
    public class SearchService
    {
        private readonly HttpClient _http;
        private readonly AuthService _authService;

        public SearchService(HttpClient httpClient, AuthService authService)
        {
            _http = httpClient;
            _authService = authService;
        }

        public async Task<TrySearchResponseDTO?> TrySearchAsync(string term)
        {
            if (_authService.IsLoggedIn && !string.IsNullOrEmpty(_authService.Token))
            {
                _http.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _authService.Token);
            }

            var response = await _http.GetAsync($"api/search/try?term={term}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<TrySearchResponseDTO>(
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }
            else
            {
                switch ((int)response.StatusCode)
                {
                    case 401:
                        throw new Exception("Lütfen giriş yapın");
                    case 404:
                        throw new Exception("Kayıt bulunamadı");
                    case 429:
                        var error429 = await response.Content.ReadAsStringAsync();
                        error429 = error429.Trim('"');
                        error429 = error429.Replace("\\\"", "\"");
                        var errorObj = JsonSerializer.Deserialize<QuotaError>(error429, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                        throw new Exception($"{errorObj.Message}");
                        
                    default:
                        var errorString = await response.Content.ReadAsStringAsync();
                        throw new Exception($"Beklenmeyen hata: {errorString}");
                }
            }
        }

        public async Task<UsageInfoDTO> GetUsageAsync()
        {
            var response = await _http.GetAsync("/api/search/usage");

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<UsageInfoDTO>() ??
                   throw new InvalidOperationException("Kullanım bilgisi okunamadı.");
        }


    }


}