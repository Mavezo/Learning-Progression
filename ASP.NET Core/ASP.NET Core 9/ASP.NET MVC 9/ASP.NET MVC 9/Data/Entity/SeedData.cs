using ASP.NET_MVC_9.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_MVC_9.Data.Entity
{
    public static class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider,
            IWebHostEnvironment hostEnvironment)
        {
            DbContextOptions<CatContext> options = serviceProvider.GetService<DbContextOptions<CatContext>>();
            using (CatContext context = new CatContext(options))
            {
                //await context.Database.EnsureDeletedAsync();
                await context.Database.EnsureCreatedAsync();
                if (context.Cats.Any())
                    return;
                string lorem = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Ut, animi? Facilis labore " +
                    "facere dicta omnis magni cumque\r\nvoluptatem. Expedita eligendi ab laudantium minus nihil " +
                    "\r\nomnis iusto, magni sint " +
                    "velit vero esse aspernatur voluptas, corporis veniam fuga culpa. Voluptatibus fugiat " +
                    "modi quae\r\nconsequatur.";
                byte[] catPersian = File.ReadAllBytes($"{hostEnvironment.WebRootPath}\\images\\Persian.jpg");
                byte[] catSiberian = File.ReadAllBytes($"{hostEnvironment.WebRootPath}\\images\\Siberian.jpg");
                byte[] catSingapura = File.ReadAllBytes($"{hostEnvironment.WebRootPath}\\images\\Singapura.jpg");
                byte[] catThai = File.ReadAllBytes($"{hostEnvironment.WebRootPath}\\images\\Thai.jpg");
                Breed persian = new Breed { BreedName = "Persian" };
                Breed siberian = new Breed { BreedName = "Siberian" };
                Breed singapura = new Breed { BreedName = "Singapura" };
                Breed thai = new Breed { BreedName = "Thai" };
                await context.Breeds.AddRangeAsync(persian, siberian, singapura, thai);

                Cat moorka = new Cat()
                {
                    CatName = "Moorka",
                    Description = lorem,
                    CatGender = CatGender.Female.ToString(),
                    IsVacinated = true,
                    Image = catPersian,
                    Breed = persian,
                    IsDeleted = false
                };

                Cat vasya = new Cat()
                {
                    CatName = "Vasya",
                    Description = lorem,
                    CatGender = CatGender.Male.ToString(),
                    IsVacinated = false,
                    Image = catSiberian,
                    Breed = siberian,
                    IsDeleted = false
                };

                Cat niva = new Cat()
                {
                    CatName = "Niva",
                    Description = lorem,
                    CatGender = CatGender.Female.ToString(),
                    IsVacinated = true,
                    Image = catSingapura,
                    Breed = singapura,
                    IsDeleted = false
                };

                Cat loki = new Cat()
                {
                    CatName = "Loki",
                    Description = lorem,
                    CatGender = CatGender.Male.ToString(),
                    IsVacinated = true,
                    Image = catThai,
                    Breed = thai,
                    IsDeleted = false
                };

                await context.Cats.AddRangeAsync(moorka, vasya, niva, loki);
                await context.SaveChangesAsync();
            }
        }

    }
}
