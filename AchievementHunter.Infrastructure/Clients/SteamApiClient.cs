using System.Net.Http.Json;
using AchievementHunter.Infrastructure.Abstractions;
using AchievementHunter.Infrastructure.Config;
using AchievementHunter.Infrastructure.Models;
using Microsoft.Extensions.Options;

namespace AchievementHunter.Infrastructure.Clients;

internal class SteamApiClient(HttpClient client, IOptions<SteamOptions> options) : ISteamApiClient
{
    public async Task<SteamOwnedGamesResponse> GetOwnedGames(string userId)
    {
        var url = $"/IPlayerServices/GetOwnedGames/v1/?key={options.Value.ApiKey}"
                  + $"&steamid={userId}&include_appinfo=true&format=json";

        return await client.GetFromJsonAsync<SteamOwnedGamesResponse>(url, CancellationToken.None)
               ?? new();
    }
}