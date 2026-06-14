namespace Discord.Domain.Base
{
    public class OAuthSettingsBase
    {
        public string ClientId { get; set; } = string.Empty;
        public string ClientSecret { get; set; } = string.Empty;
    }
}
