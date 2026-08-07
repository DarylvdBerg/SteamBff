using AchievementHunter.Application.Dto;
using AchievementHunter.Domain.Models;

namespace AchievementHunter.Application.Abstractions;

public interface IOwnedGamesHandler
{
    Task<IReadOnlyList<OwnedGameDto>> GetOwnedGames(string userId);
}