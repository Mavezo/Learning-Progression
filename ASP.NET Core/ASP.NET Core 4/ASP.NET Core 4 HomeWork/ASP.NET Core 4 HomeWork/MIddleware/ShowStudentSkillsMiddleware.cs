using Microsoft.Extensions.Options;
using System.Text;

namespace ASP.NET_Core_4_HomeWork.MIddleware
{
    public class ShowStudentSkillsMiddleware
    {
        private readonly string color;

        public ShowStudentSkillsMiddleware(RequestDelegate next, string color) 
        {
            this.color = color;
        }

        public async Task InvokeAsync(HttpContext context, IOptions<Student> options)
        {
            Student? student = options.Value;
            StringBuilder sb = new StringBuilder($"<p style='color:{color};'>Skills: <br>");
            foreach (var item in student.Skills) 
            {
                sb.AppendLine($"-{item}<br>");
            }
            sb.AppendLine("</p>");
            context.Response.Headers.ContentType = "text/html;charset=utf-8";  
            await context.Response.WriteAsync(sb.ToString());

        }

    }
}
