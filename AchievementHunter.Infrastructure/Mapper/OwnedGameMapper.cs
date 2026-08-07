using AchievementHunter.Domain.Models;
using AchievementHunter.Infrastructure.Models;

namespace AchievementHunter.Infrastructure.Mapper;

public static class OwnedGameMapper
{
    public static OwnedGame ToDomain(this SteamOwnedGame game) => new(
        appId: game.AppId,
        name: game.Name,
        imageUrl: game.ImgIconUrl
    );
}