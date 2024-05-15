using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ASP.NET_Core_2
{
    public class AuthenticateMiddleware
    {
        private readonly RequestDelegate next;
        private readonly string token;

        public AuthenticateMiddleware(RequestDelegate next, string token)
        {
            this.next = next;
            this.token = token;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            string token = context.Request.Query["token"];
            if (token == this.token)
            {
                await next.Invoke(context);
            }
            else
            {
                context.Response.StatusCode = 403;
            }
            await Console.Out.WriteLineAsync(context.Request.Path);
        }


    }
}
