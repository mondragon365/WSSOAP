using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.Extensions.Logging;
public class MyMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger _logger;
    public MyMiddleware(RequestDelegate next, ILoggerFactory logFactory)
    {
        _next = next;

        _logger = logFactory.CreateLogger("MyMiddleware");
    }
    public async Task InvokeAsync(HttpContext context)
    {
        var bodyStr = "";
        var req = context.Request;
        req.EnableBuffering();

        using (StreamReader reader = new StreamReader(req.Body, Encoding.UTF8, true, 1024, true))
        {
            bodyStr = await reader.ReadToEndAsync();
            req.Body.Position = 0;
        }

        await _next(context);
    }
}
public static class MyMiddlewareExtensions
{
    public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<MyMiddleware>();
    }
}