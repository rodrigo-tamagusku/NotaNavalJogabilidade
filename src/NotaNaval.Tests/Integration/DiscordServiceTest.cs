using Discord.Application.UseCase;
using Discord.Domain.Configurations;
using Discord.Infrastructure.Service;
using Microsoft.Extensions.Configuration;

namespace NotaNaval.Tests.Integration
{
    public class DiscordServiceTest
    {
        private DownloadGroupFilesUseCase useCase;
        private IConfigurationRoot config;
        private DiscordOAuthSettings settings;
        private DiscordOAuth2Service authService;

        public DiscordServiceTest()
        {
            using var httpClient = new HttpClient();

            config = new ConfigurationBuilder()
                .AddUserSecrets<DiscordServiceTest>()
                .Build();

            settings = new DiscordOAuthSettings();
            config.GetSection(DiscordOAuthSettings.SectionName).Bind(settings);
            this.authService = new DiscordOAuth2Service(settings);
            var discordService = new DiscordService(httpClient, settings, authService);
            this.useCase = new DownloadGroupFilesUseCase(discordService);
        }
        [Theory]
        [InlineData(998983907913510993)]
        public async Task ExecuteAsync_DownloadFilesFromChannelAsync(ulong channelId)
        {
            var destinationFolder = @"C:\DiscordDownloads";
            await useCase.ExecuteAsync(channelId, destinationFolder, TestContext.Current.CancellationToken);
        }
    }
}
