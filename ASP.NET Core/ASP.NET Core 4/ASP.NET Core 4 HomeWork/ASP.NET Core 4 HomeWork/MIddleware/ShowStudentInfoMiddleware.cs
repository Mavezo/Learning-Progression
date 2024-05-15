using Microsoft.Extensions.Options;
using System.Drawing;

namespace ASP.NET_Core_4_HomeWork.MIddleware
{
    public class ShowStudentInfoMiddleware
    {
        private readonly string color;

        public ShowStudentInfoMiddleware(RequestDelegate next, string color)
        {
            this.color = color;
        }

        public async Task InvokeAsync(HttpContext context, IOptions<Student> options)
        {
            Student? student = options.Value;
            context.Response.Headers.ContentType = "text/html;charset=utf-8";
            await context.Response.WriteAsync($"<p style='color: {color};'>Student:<br>Name:  {student.Name}<br>Surname:  {student.Surname}<br>Age:  {student.Age}<br></p>");

        }



    }
}
