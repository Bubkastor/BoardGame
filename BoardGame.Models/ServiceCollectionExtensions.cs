using BoardGame.Models.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace BoardGame.Models;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddModelsDependencies(this IServiceCollection services)
    {
        services.AddSingleton<INpcRepository, NpcRepository>();
        services.AddSingleton<IGameStateRepository, GameStateRepository>();
        services.AddSingleton<IPlayFieldTilRepository, PlayFieldTilRepository>();
        services.AddSingleton<IStartScenarioRepository, StartScenarioRepository>();
        
        return services;
    }
}
