using AchievementHunter.Domain.Models;

namespace AchievementHunter.Application.Abstractions;

public interface IOwnedGamesRepository
{
    Task<IReadOnlyList<OwnedGame>> GetOwnedGames(string userId);
}