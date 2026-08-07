namespace AchievementHunter.Infrastructure.Config;

public sealed class SteamOptions
{
    public const string SectionName = "Steam";
    public required string BaseUrl { get; init; }
    public required string ApiKey { get; init; }
}