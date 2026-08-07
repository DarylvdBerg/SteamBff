using AchievementHunter.Application.Dto;
using AchievementHunter.Domain.Models;

namespace AchievementHunter.Application.Mappings;

internal static class OwnedGameMapper
{
    public static OwnedGameDto ToDto(this OwnedGame game) => new(
        appId: game.AppId, 
        name: game.Name,
        imageUrl: game.ImageUrl
    );
}