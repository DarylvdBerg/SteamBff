using Microsoft.Extensions.DependencyInjection;
using AchievementHunter.Application.Abstractions;
using AchievementHunter.Application.Handlers;

namespace AchievementHunter.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddTransient<IOwnedGamesHandler, GetOwnedGamesHandler>();
        
        return services;
    }
}