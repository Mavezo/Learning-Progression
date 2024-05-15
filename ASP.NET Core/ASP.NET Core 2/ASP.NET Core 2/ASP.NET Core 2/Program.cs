using ASP.NET_Core_2;
using ASP.NET_Core_2.Utils;
using System.Net.Security;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Use(async (context, next) =>
{
    await next.Invoke();
    Console.WriteLine($"Time of request: {DateTime.Now.ToLongTimeString()}"); 
});

//app.UseMiddleware<ErrorHandlingMiddleware>();
app.UseMyErrorHandligh();
//app.UseMiddleware<AuthenticateMiddleware>("tselik");

//app.UseMyAuthentication("tselik");
app.UseMiddleware<RoutingMiddleware>();


app.Run();