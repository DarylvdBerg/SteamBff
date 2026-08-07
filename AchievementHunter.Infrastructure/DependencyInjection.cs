using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using AchievementHunter.Application.Abstractions;
using AchievementHunter.Infrastructure.Abstractions;
using AchievementHunter.Infrastructure.Clients;
using AchievementHunter.Infrastructure.Config;
using AchievementHunter.Infrastructure.Repositories;

namespace AchievementHunter.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<IOwnedGamesRepository, SteamOwnedGamesRepository>();
        
        services
            .AddOptions<SteamOptions>()
            .Bind(configuration.GetSection(SteamOptions.SectionName))
            .ValidateOnStart();

        services
            .AddHttpClient<ISteamApiClient, SteamApiClient>((sp, client) =>
            {
                var options = sp.GetRequiredService<IOptions<SteamOptions>>().Value;
                client.BaseAddress = new Uri(options.BaseUrl);
                client.Timeout = TimeSpan.FromSeconds(30);
            });
        
        return services;
    }
}