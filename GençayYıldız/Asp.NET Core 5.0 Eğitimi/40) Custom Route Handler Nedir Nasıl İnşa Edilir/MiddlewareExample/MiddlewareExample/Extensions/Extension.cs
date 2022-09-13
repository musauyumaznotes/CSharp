using Microsoft.AspNetCore.Builder;
using MiddlewareExample.Middlewares;

namespace MiddlewareExample.Extensions
{
    public static class Extension
    {
        public static IApplicationBuilder UseHello(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<HelloMiddleware>();
        }
    }
}
