namespace AchievementHunter.Application.Dto;

public class OwnedGameDto(int appId, string name, string imageUrl)
{
    public int AppId { get; } = appId;
    public string Name { get; } = name;
    public string ImageUrl { get; }  = imageUrl;
}