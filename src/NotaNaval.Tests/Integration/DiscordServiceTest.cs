using Discord.Application.UseCase;
using Discord.Infrastructure.Service;

namespace NotaNaval.Tests.Integration
{
    public class DiscordServiceTest
    {
        private DownloadGroupFilesUseCase useCase;

        public DiscordServiceTest()
        {
            var botToken = "YOUR_BOT_TOKEN_HERE";

            using var httpClient = new HttpClient();
            var discordService = new DiscordService(httpClient, botToken);
            this.useCase = new DownloadGroupFilesUseCase(discordService);

            Console.WriteLine("Download complete.");
        }
        [Fact]
        public async Task ExecuteAsync_DownloadFilesFromChannelAsync()
        {
            ulong channelId = 123456789012345678UL;
            var destinationFolder = @"C:\DiscordDownloads";
            await useCase.ExecuteAsync(channelId, destinationFolder, TestContext.Current.CancellationToken);
        }
    }
}
