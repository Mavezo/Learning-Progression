namespace ASP.NET_Core_2
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate next;

        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await next.Invoke(context);

            if (context.Response.StatusCode == 403)
            {
                context.Response.Headers.ContentType = "text/html;charset=utf-8";
                await context.Response.WriteAsync("<h2>You haven't access to this state!</h2>");
            }
            else if (context.Response.StatusCode == 404)
            {
                context.Response.Headers.ContentType = "text/html;charset=utf-8";
                await context.Response.WriteAsync("<h2 style='color:red;'>Resource not found</h2>");
            }
        }

    }
}
