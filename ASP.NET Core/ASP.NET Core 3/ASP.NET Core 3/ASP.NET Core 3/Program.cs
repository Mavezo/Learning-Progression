using ASP.NET_Core_2;
using ASP.NET_Core_2_HomeWork;
using ASP.NET_Core_3;
using System.Reflection.Metadata.Ecma335;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IGetResult, Fibonacci>();
builder.Services.AddTransient<NumberProcessingService>();

var app = builder.Build();




app.UseMiddleware<ErrorHandlingMiddleware>();
//app.UseMiddleware<AuthenticateMiddleware>("roman");

app.Map("/", async (context) =>
{
    if (int.TryParse(context.Request.Query["index"], out int number))
    {
        var factorialProcessor = app.Services.GetService<NumberProcessingService>();
        await context.Response.WriteAsync($"F({number}) = {factorialProcessor.GetResult(number)}");
    }
    else
    {
        await context.Response.WriteAsync("Enter the number in this way: https://localhost:7291/?token=YourToken&index=10");
    }
});




app.Run();
