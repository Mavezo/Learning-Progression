using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary
{
    public class MyContextShop : IDesignTimeDbContextFactory<MyGoodsContext>
    {
        public MyGoodsContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<MyGoodsContext>();
            IConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            IConfigurationRoot config = builder.Build();
            string connStr = config.GetConnectionString("sqlConnStr");
            optionBuilder.UseSqlServer(connStr);
            var options = optionBuilder.Options;
            return new MyGoodsContext(options);
        }
    }
}
