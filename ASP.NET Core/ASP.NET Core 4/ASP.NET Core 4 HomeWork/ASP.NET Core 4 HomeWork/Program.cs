using ASP.NET_Core_4_HomeWork;
using ASP.NET_Core_4_HomeWork.MIddleware;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("Configuration/student.json");
builder.Services.Configure<Student>(builder.Configuration.GetSection("student"));
var appConfig = builder.Configuration;
var app = builder.Build();

app.Map("/home", (context) => {
    string color = appConfig["color"];
    context.UseMiddleware<ShowStudentInfoMiddleware>(color);
});
app.Map("/skills", (context) =>
{
    string color = appConfig["color"];
    context.UseMiddleware<ShowStudentSkillsMiddleware>(color);
});


app.MapGet("/", () => "Hello World!");

app.Run();
