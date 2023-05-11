using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace ADO.NET_Code_First.Models
{
    public class MyGamesContext : DbContext
    {
 
      public string connectionString { get; set; }
       public DbSet<Games> Games { get; set; } = null;

        public DbSet<Authors> Authors { get; set; } = null;

        public MyGamesContext(DbContextOptions<MyGamesContext> options) : base(options)
        {
            //  Database.EnsureCreated();
        }

        public MyGamesContext() {
        }
        //public MyGamesContext(string connectionString)
        //{
        //    this.connectionString = connectionString;
        // //   Database.EnsureCreated();
        //}


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Data Source=MSI;Integrated Security=True;Initial Catalog=GamesTest;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
        //        //optionsBuilder.UseSqlServer(connectionString);

        //    }
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
