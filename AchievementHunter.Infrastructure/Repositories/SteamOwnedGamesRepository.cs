using AchievementHunter.Application.Abstractions;
using AchievementHunter.Domain.Models;
using AchievementHunter.Infrastructure.Abstractions;
using AchievementHunter.Infrastructure.Mapper;

namespace AchievementHunter.Infrastructure.Repositories;

internal class SteamOwnedGamesRepository(ISteamApiClient steamApiClient) : IOwnedGamesRepository
{
    public async Task<IReadOnlyList<OwnedGame>> GetOwnedGames(string userId)
    {
        var response = await steamApiClient.GetOwnedGames(userId);
        return response.OwnedGames.Select(game => game.ToDomain()).ToList();
    }
}