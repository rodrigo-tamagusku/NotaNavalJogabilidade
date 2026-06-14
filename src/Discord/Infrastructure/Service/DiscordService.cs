using Discord.Application.Common.Interfaces;
using Discord.Domain.Configurations;
using Discord.Rest;

namespace Discord.Infrastructure.Service
{
    public class DiscordService : IDiscordService
    {
        private readonly HttpClient _httpClient;
        private readonly DiscordOAuthSettings settings;
        private readonly DiscordOAuth2Service authService;

        public DiscordService(HttpClient httpClient, DiscordOAuthSettings settings, DiscordOAuth2Service authService)
        {
            _httpClient = httpClient;
            this.settings = settings;
            this.authService = authService;
        }

        public async Task DownloadFilesFromChannelAsync(ulong channelId, string destinationPath, CancellationToken cancellationToken)
        {
            using var discord = new DiscordRestClient();
            string? token = await authService.GetBearerTokenAsync();
            await discord.LoginAsync(TokenType.Bearer, token);

            var channel = await discord.GetChannelAsync(channelId) as IMessageChannel;
            if (channel == null) throw new ArgumentException("Invalid channel or bot lacks access.");

            Directory.CreateDirectory(destinationPath);

            // Fetch messages sequentially using IAsyncEnumerable
            await foreach (var page in channel.GetMessagesAsync(limit: 100))
            {
                foreach (var message in page)
                {
                    if (cancellationToken.IsCancellationRequested) return;

                    foreach (var attachment in message.Attachments)
                    {
                        var filePath = Path.Combine(destinationPath, attachment.Filename);

                        // Download file via HTTP
                        using var response = await _httpClient.GetAsync(attachment.Url, cancellationToken);
                        if (response.IsSuccessStatusCode)
                        {
                            await using var fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
                            await response.Content.CopyToAsync(fs, cancellationToken);
                        }
                    }
                }
            }
        }
    }


}
