using System.Reflection.Metadata.Ecma335;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddInMemoryCollection(new Dictionary<string, string>
{
    {"age", "27"},
    {"technology", "ASP.NET Core" }
});
var app = builder.Build();

//app.Configuration["name"] = "roman";
//app.Configuration["company"] = "BCTTest";

app.MapGet("/info", () => $"Name: {app.Configuration["name"]}, Company: {app.Configuration["company"]}");

app.Map("/show", (IConfiguration appConfig) =>
{
    string name = appConfig["name"];
    string company = appConfig["company"];
    return $"Name: {name}, Company: {company}";

});

app.Map("/tech", (IConfiguration appConfig) =>
{
    //string age = appConfig["age"];
    //string technology = appConfig["technology"];
    //return $"In: {technology} from: {age}";
    IConfigurationSection loggingSection = appConfig.GetSection("Logging:LogLevel");
    StringBuilder sb = new StringBuilder();
    sb.AppendLine("<table><tr><th>Key</th><th>Value</th></tr>");
    foreach (IConfigurationSection section in loggingSection.GetChildren()) 
    {
        sb.AppendLine($"<tr><td>{section.Key}</td><td>{section.Value}</td></tr>");
    }
    sb.AppendLine("</table>");
    return $"{sb.ToString()}";
    //loggingSection.GetChildren()
    //string loggingLevelDef = appConfig["Logging:LogLevel:Default"];
    //string loggingLevelAsp= appConfig["Logging:LogLevel:Microsoft.AspNetCore"];
    //return $"Logging:LogLevel:Default->{loggingLevelDef}\r\nLogging:LogLevel:Microsoft.AspNetCore->{loggingLevelAsp}";

});

app.Run();

//string GetSectionData(IConfigurationSection section, string str)
//{
//    str = $"\"{section.Key}\":";
//    if(section.GetChildren().Count() == 0)
//    {

//    }
//}


