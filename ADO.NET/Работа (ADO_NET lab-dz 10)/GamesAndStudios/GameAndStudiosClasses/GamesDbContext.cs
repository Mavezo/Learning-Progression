using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameAndStudiosClasses
{
    public class GamesDbContext : DbContext
    {
        public DbSet<Studios> Studios { get; set; } = null!;
        public DbSet<Genres> Genres { get; set; } = null!;
        public DbSet<Games> Games { get; set; } = null!;

        public StringBuilder log { get; set; } = new StringBuilder();

        public GamesDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(t=>log.AppendLine(t));
            optionsBuilder.UseSqlite("Data Source=GamesDb.db");
       
        }



    }
}
