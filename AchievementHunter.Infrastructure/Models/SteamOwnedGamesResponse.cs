using Newtonsoft.Json;
using AchievementHunter.Domain.Models;

namespace AchievementHunter.Infrastructure.Models;

public class SteamOwnedGamesResponse
{
    [JsonProperty("game_count")]
    public int GameCount { get; init; }
    
    [JsonProperty("games")]
    public IReadOnlyList<SteamOwnedGame> OwnedGames { get; init; }
}