using Microsoft.EntityFrameworkCore;

namespace ASP.NET_MVC_9.Data.Entity
{
    public class CatContext : DbContext
    {

        public DbSet<Cat> Cats { get; set; }
        public DbSet<Breed> Breeds { get; set; }
        public CatContext(DbContextOptions options) : base(options)
        {
            
        }
 


    }
}
