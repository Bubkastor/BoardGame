using BoardGame.Persistence.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using BoardGame.Extensions.Options;
namespace BoardGame.Persistence;

public static class BoardGameDbExtensions
{ 
    /// <summary>
    /// Конфигурирует BoardGameDb хранилище.
    /// </summary>
    /// <param name="services">Экземпляр <see cref="IServiceCollection" />, в который нужно добавить сервисы.</param>
    /// <param name="boardGameDbStorageConfiguration">Конфигурация BoardGameDb хранилища.</param>
    /// <returns>Экземпляр <see cref="IServiceCollection" />, указаннный в <paramref name="services" />.</returns>
    public static IServiceCollection ConfigureBoardGameDb(this IServiceCollection services, IConfiguration boardGameDbStorageConfiguration)
    {
        // добавляем auto mapping 
        services.AddAutoMapper(cfg =>
        {
             cfg.AllowNullCollections = true;
        });

        // добавляем настройки хранилища
        services.AddOptions<BoardGameDbStorageSettings>().BindAndValidateDataAnnotationsOnStartRecursively(boardGameDbStorageConfiguration);

        // добавляем сервисы
        services.TryAddSingleton<BoardGameDbOptions>();
        services.TryAddScoped<BoardGameDbStorage>();

        // добавляем репозитории
        services.AddScoped<IGameSessionRepository, GameSessionRepository>();
        

        return services;
    }
}
