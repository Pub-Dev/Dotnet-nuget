using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace PubDev.Nuget.HttpMiddleware;

public class PubDevMiddleware
{
    private readonly ILogger<PubDevMiddleware> _logger;
    private readonly RequestDelegate _next;

    public PubDevMiddleware(
        ILogger<PubDevMiddleware> logger,
        RequestDelegate next)
    {
        _logger = logger;
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        _logger.LogWarning("🍻🍻 Pub Dev 🍻🍻, iniciando execução...");

        var stopwatch = new Stopwatch();

        try
        {
            stopwatch.Start();

            await _next(context);

            _logger.LogWarning("🍻🍻 Pub Dev 🍻🍻, finalizando execução...{time}", stopwatch.Elapsed.TotalMilliseconds);

        }
        catch (Exception ex )
        {
            _logger.LogWarning("❌😒 Pub Dev ❌😒, erro na execução execução...{time} - {@error}", stopwatch.Elapsed.TotalMilliseconds, ex);
        }
    }
}
