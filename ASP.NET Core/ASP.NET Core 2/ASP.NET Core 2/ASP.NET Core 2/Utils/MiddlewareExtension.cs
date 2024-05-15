using ASP.NET_Core_2;


namespace ASP.NET_Core_2.Utils
{
    public static class MiddlewareExtension
    {
        public static IApplicationBuilder UseMyErrorHandligh(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ErrorHandlingMiddleware>();
        }

        public static IApplicationBuilder UseMyAuthentication(this IApplicationBuilder app, string token)
        {
            return app.UseMiddleware<AuthenticateMiddleware>(token);
        }
    }
}
