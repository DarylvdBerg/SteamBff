using AchievementHunter.Infrastructure.Models;

namespace AchievementHunter.Infrastructure.Abstractions;

public interface ISteamApiClient
{
    Task<SteamOwnedGamesResponse> GetOwnedGames(string userId);
}