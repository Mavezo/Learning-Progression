using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

DateTime date = DateTime.Now;

app.MapGet("/", () => $"{date.DayOfYear}");

app.MapGet("/fullname", () => $"Roman Tselik");


app.MapGet("/process", () => $"{Process.GetCurrentProcess().ProcessName}\n{date.ToLocalTime()}");



app.Run();
