using System.Diagnostics;
using LinqToDB;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace BoardGame.Persistence;

internal class BoardGameDbOptions
{
    public DataOptions DataOptions { get; }

    public BoardGameDbOptions(IOptions<BoardGameDbStorageSettings> settingsOpts)
    {

        var settings = settingsOpts.Value;

        var dataOptions = new DataOptions()
            .UseSqlServer(settings.ConnectionString);

        if(settings.LogQueries)
        {
            dataOptions = dataOptions
                .UseTraceLevel(TraceLevel.Verbose)
                .UseTraceWith(WriteTraceLine);
        }
        else
        {
            dataOptions = dataOptions
                .UseTraceLevel(TraceLevel.Off)
                .UseTraceWith(delegate { });
        }

        this.DataOptions = dataOptions;
    }

    private void WriteTraceLine(string? traceMessage, string? traceCategoryDisplayName, TraceLevel traceLevel)
    {
        if (traceMessage == null) return;

        var logLevel = traceLevel switch
        {
            TraceLevel.Error => LogLevel.Error,
            TraceLevel.Warning => LogLevel.Warning,
            TraceLevel.Info => LogLevel.Information,
            TraceLevel.Verbose => LogLevel.Trace,
            _ => LogLevel.None
        };
    }
}