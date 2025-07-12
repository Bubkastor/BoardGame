using System.Reflection;
using FluentMigrator.Runner;
using FluentMigrator.Runner.Initialization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BoardGame.Persistence.Migrations;

public static class BoardGameMigrationsDbExtensions
{
      /// <summary>
    /// Обновляет PawnDb хранилище.
    /// </summary>
    /// <param name="host">Хост.</param>
    /// <param name="boardGameDbStorageConfiguration">Конфигурация PawnDb хранилища.</param>
    public static IHost UpdateBoardGameDb(this IHost host, IConfiguration boardGameDbStorageConfiguration)
    {
        //using var log = host.Services.GetRequiredService<ILoggerFactory>().CreateLogger(typeof(BoardGameMigrationsDbExtensions));

        var connectionString = boardGameDbStorageConfiguration.GetValue<string>("ConnectionString");
        if (connectionString == null)
            throw new ArgumentException($"Настройка {(boardGameDbStorageConfiguration is IConfigurationSection section ? $"{section.Path}:" : "")}ConnectionString не определена.");

        // configure the dependency injection services
        using var serviceProvider = CreateServices(connectionString);

        // put the database update into a scope to ensure that all resources will be disposed
        using var scope = serviceProvider.CreateScope();

        // instantiate the runner
        var migrationRunner = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();

        // execute the migrations
        migrationRunner.MigrateUp();

        return host;
    }

    /// <summary>
    /// Configures the dependency injection services.
    /// </summary>
    private static ServiceProvider CreateServices(string connectionString)
    {
        return new ServiceCollection()
            // add common FluentMigrator services
            .AddFluentMigratorCore()
            // configure runner
            .ConfigureRunner(b => b
                //.AddSqlServer2016()
                // Add Postgres 15 support to FluentMigrator
                .AddPostgres15_0()
                .WithGlobalConnectionString(connectionString)
                .WithMigrationsIn(false, Assembly.GetExecutingAssembly())
            )
            // enable logging to console in the FluentMigrator way
            .AddLogging(lb => lb.AddFluentMigratorConsole())
            // build the service provider
            .BuildServiceProvider(false);
    }

    /// <summary>
    /// Adds the migrations.
    /// </summary>
    /// <param name="builder">The runner builder.</param>
    /// <param name="assemblies">The target assemblies.</param>
    /// <returns>The runner builder.</returns>
    private static IMigrationRunnerBuilder WithMigrationsIn(this IMigrationRunnerBuilder builder, bool scanOnlyExportedTypes, params Assembly[] assemblies)
    {
        builder.Services.AddSingleton<IMigrationSourceItem>(new AssemblyMigrationSourceItem(assemblies) { ScanOnlyExportedTypes = scanOnlyExportedTypes });
        return builder;
    }
}