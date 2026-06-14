namespace Discord.Domain.Configurations
{
    /// <summary>
    /// https://discord.com/developers/
    /// </summary>
    public class DiscordBotSettings
    {
        public string ApiKeyToken { get; set; } = string.Empty;

        public static string SectionName = nameof(DiscordBotSettings);
    }
}
