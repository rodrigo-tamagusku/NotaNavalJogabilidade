using Discord.Application.Common.Interfaces;

namespace Discord.Application.UseCase
{
    public class DownloadGroupFilesUseCase
    {
        private readonly IDiscordService _discordService;

        public DownloadGroupFilesUseCase(IDiscordService discordService)
        {
            _discordService = discordService;
        }

        public async Task ExecuteAsync(ulong channelId, string destinationPath, CancellationToken cancellationToken)
        {
            await _discordService.DownloadFilesFromChannelAsync(channelId, destinationPath, cancellationToken);
        }
    }


}
