namespace AchievementHunter.Domain.Models;

public class OwnedGame(int appId, string name, string imageUrl)
{
    public int AppId { get; } = appId;
    public string Name { get; } = name;
    public string ImageUrl { get; } = imageUrl;
}