namespace Discord.Domain.Entities
{
    public class DiscordFile
    {
        public string FileName { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public long Size { get; set; }
    }
}
