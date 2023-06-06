using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP_3___ADO.NET__dz__value_work.Models
{
    public class HardwareDbContext : DbContext
    {
        public DbSet<Hardware> Hardwares { get; set; }
        public DbSet<Prices> Prices { get; set; }


        public HardwareDbContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=HardwareDb.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hardware>().HasData(
                new Hardware
                {
                    Id = 1,
                    Name = "AMD Ryzen 5 5600G 3.9 GHz/16MB"
                }, new Hardware
                {
                    Id = 2,
                    Name = "Intel Core i7-13700K 3.4Gh/18MB"
                }, new Hardware
                {
                    Id = 3,
                    Name = "Intel Pentium Gold G6405 4.1Ghz/4MB"
                }, new Hardware
                {
                    Id = 4,
                    Name = "AMD Ryzen 3 4300G 3.8GHz/4MB"
                });

            modelBuilder.Entity<Prices>().HasData(new Prices
            {
                Id = 1,
                HardwareId = 1,
                Price = 1000
            }, new Prices
            {
                Id = 2,
                HardwareId = 2,
                Price = 2000
            }, new Prices
            {
                Id = 3,
                HardwareId = 3,
                Price = 3000
            }, new Prices
            {
                Id = 4,
                HardwareId = 4,
                Price = 4000
            });
        }






    }
}
