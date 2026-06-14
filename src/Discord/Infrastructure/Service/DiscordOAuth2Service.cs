using Discord.Domain.Configurations;
using System.Text.Json;

namespace Discord.Infrastructure.Service
{
    public class DiscordOAuth2Service(DiscordOAuthSettings settings)
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public async Task<string?> GetBearerTokenAsync(string redirectUri = "https://discord.com/developers")
        {
            var tokenEndpoint = "https://discord.com/api/oauth2/token";

            // Prepare the x-www-form-urlencoded payload required by Discord
            var payload = new Dictionary<string, string>
        {
            { "client_id", settings.ClientId },
            { "client_secret", settings.ClientSecret },
            { "grant_type", "client_credentials" },
            { "scope", "identify connections" },
            { "redirect_uri", redirectUri }
        };

            var content = new FormUrlEncodedContent(payload);

            // Send the request
            var response = await _httpClient.PostAsync(tokenEndpoint, content);
            var responseString = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Failed to fetch token: {responseString}");
            }

            // Parse the JSON response to extract the access_token
            using var jsonDoc = JsonDocument.Parse(responseString);
            if (jsonDoc.RootElement.TryGetProperty("access_token", out var accessTokenElement))
            {
                string? accessToken = accessTokenElement.GetString();
                settings.AccessToken = accessToken;
                return accessToken;
            }

            throw new Exception("Access token not found in the response.");
        }
    }
}
