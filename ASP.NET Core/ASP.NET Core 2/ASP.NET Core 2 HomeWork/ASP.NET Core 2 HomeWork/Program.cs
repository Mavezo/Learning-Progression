using ASP.NET_Core_2;
using ASP.NET_Core_2_HomeWork;
using System.Reflection.Metadata.Ecma335;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

static int Fibonacci(int value)
{
    if (value < 0)
    {
        return 0;
    }
    if(value == 1)
    {
        return 1;
    }

    return Fibonacci(value - 1) + Fibonacci(value - 2);
}

app.UseMiddleware<ErrorHandlingMiddleware>();
app.UseMiddleware<AuthenticateMiddleware>("roman");

app.Map("/", async (context) =>
{
    if (int.TryParse(context.Request.Query["index"], out int number))
    {
        await context.Response.WriteAsync($"F({number}) = {Fibonacci(number)}");
    }
    else
    {
        await context.Response.WriteAsync("Enter the number in this way: https://localhost:7291/?token=YourToken&index=10");
    }
});




app.Run();
