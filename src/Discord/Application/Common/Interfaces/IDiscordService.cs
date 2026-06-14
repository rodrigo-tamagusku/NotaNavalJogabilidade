using Discord.Domain.Entities;

namespace Discord.Application.Common.Interfaces
{
    public interface IDiscordService
    {
        Task DownloadFilesFromChannelAsync(ulong channelId, string destinationPath, CancellationToken cancellationToken);
    }

}
