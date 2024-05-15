using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ASP.NET_Core_2
{
    public class RoutingMiddleware
    {
        private readonly RequestDelegate next;
        public RoutingMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            string? path = context.Request.Path.Value?.ToLower();

            string fullpath = $"html{path}";
            if (File.Exists(fullpath))
            {
                context.Response.Headers.ContentType = "text/html;charset=utf-8";
                await context.Response.SendFileAsync(fullpath);
            }
            else
            {

            if (path == "/home")
                await context.Response.WriteAsync("Hello from Home");
            else if (path == "/time")
                await context.Response.WriteAsync($"Current time: {DateTime.Now.ToLongTimeString()}");
            else
                context.Response.StatusCode = 404;
            } 
        }

    }
}
