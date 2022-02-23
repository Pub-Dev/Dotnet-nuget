using Microsoft.AspNetCore.Builder;

namespace PubDev.Nuget.HttpMiddleware;

public static class PubDevMiddlewareExtensions
{
    public static IApplicationBuilder UsePubDev(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<PubDevMiddleware>();
    }
}