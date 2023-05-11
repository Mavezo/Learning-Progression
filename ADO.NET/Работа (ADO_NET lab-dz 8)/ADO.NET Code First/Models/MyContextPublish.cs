using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.IO;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ADO.NET_Code_First.Models
{
    public class MyContextPublish : IDesignTimeDbContextFactory<MyGamesContext>
    {
        public MyGamesContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<MyGamesContext>();
            IConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            IConfigurationRoot config = builder.Build();
            //string connStr = config.GetSection("ConnectionStrings:sqlConnStr").Value;
            string connStr = config.GetConnectionString("sqlConnStr");
            optionBuilder.UseSqlServer(connStr);
            var options = optionBuilder.Options;
            return new MyGamesContext(options);
        }

    }
}
