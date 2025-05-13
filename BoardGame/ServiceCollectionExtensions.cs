using BoardGame.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace BoardGame;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationDependencies(this IServiceCollection services)
    {
        services.AddSingleton<INpcRepository, NpcRepository>();
        services.AddSingleton<IGameStateRepository, GameStateRepository>();
        services.AddSingleton<IPlayFieldTilRepository, PlayFieldTilRepository>();
        services.AddSingleton<IStartScenarioRepository, StartScenarioRepository>();
        
        return services;
    }
}
