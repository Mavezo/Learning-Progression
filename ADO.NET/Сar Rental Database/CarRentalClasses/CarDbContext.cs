using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalClasses
{
    public class CarDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; } = null!;
        public DbSet<Promotion> Promotions { get; set; } = null!;
        public CarDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite("Data source=CarDb.db");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Car>().HasKey(nameof(Car.Id));
            builder.Entity<Promotion>().HasKey(nameof(Promotion.Id));

            builder.Entity<Car>().HasData(
            new Car
            {
                Id = 1,
                StateRegistrationNumber = "BL19957",
                Brand = "Mercedes-Benz",
                Model = "A-Class",
                CostOfRentingPerDay = 50,
                MaxDistance = 500
            },
            new Car
            {
                Id = 2,
                StateRegistrationNumber = "EL574CE",
                Brand = "BMW",
                Model = "X7",
                CostOfRentingPerDay = 70,
                MaxDistance = 1500
            },
            new Car
            {
                Id = 3,
                StateRegistrationNumber = "GA0917C",
                Brand = "Audi",
                Model = "A8",
                CostOfRentingPerDay = 40,
                MaxDistance = 1200
            });

            builder.Entity<Promotion>().HasData(
            new Promotion
            {
                Id = 1,
                StartDateOfPromotion = new DateTime(2023, 12, 24),
                EndDateOfPromotion = new DateTime(2024, 1, 7),
                NameOfPromotion = "New Year 2024",
                DecreaseInRentalCostsPercent = 19,
                IncreaseMaximumDistancePercent = 25,
            },
            new Promotion
            {
                Id = 2,
                StartDateOfPromotion = new DateTime(2024, 03, 20),
                EndDateOfPromotion = new DateTime(2024, 03, 22),
                NameOfPromotion = "Company Birthday 2024",
                DecreaseInRentalCostsPercent = 30,
                IncreaseMaximumDistancePercent = 40,
            },
            new Promotion
            {
                Id = 3,
                StartDateOfPromotion = new DateTime(2024, 7, 24),
                EndDateOfPromotion = new DateTime(2024, 7, 31),
                NameOfPromotion = "National Road Trip 2024",
                DecreaseInRentalCostsPercent = 10,
                IncreaseMaximumDistancePercent = 20
            },
            new Promotion
            {
                Id = 4,
                StartDateOfPromotion = new DateTime(2023, 7, 1),
                EndDateOfPromotion = new DateTime(2025, 9, 1),
                NameOfPromotion = "Test",
                DecreaseInRentalCostsPercent = 10,
                IncreaseMaximumDistancePercent = 20
            }
            );



        }

    }
}
