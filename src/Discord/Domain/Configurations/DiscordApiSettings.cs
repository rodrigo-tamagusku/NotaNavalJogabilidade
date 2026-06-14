namespace Discord.Domain.Configurations
{
    public class DiscordApiSettings
    {
        public string ApiKeyToken { get; set; } = string.Empty;

        public static string SectionName = nameof(DiscordApiSettings);
    }
}
