using AchievementHunter.Application.Abstractions;
using AchievementHunter.Application.Dto;
using AchievementHunter.Application.Mappings;
using AchievementHunter.Domain.Models;

namespace AchievementHunter.Application.Handlers;

internal class GetOwnedGamesHandler(IOwnedGamesRepository repo) : IOwnedGamesHandler
{
    public async Task<IReadOnlyList<OwnedGameDto>> GetOwnedGames(string userId)
    {
        var response = await repo.GetOwnedGames(userId);
        return response.Select(game => game.ToDto()).ToList();
    }
}