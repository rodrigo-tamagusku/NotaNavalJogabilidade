using Discord.Domain.Base;

namespace Discord.Domain.Configurations
{
    /// <summary>
    /// https://discord.com/developers/
    /// </summary>
    public class DiscordOAuthSettings : OAuthSettingsBase
    {
        public string Code { get; set; } = string.Empty;
        public string? AccessToken { get; set; }
        public static string SectionName = nameof(DiscordOAuthSettings);
    }
}
