using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_MVC_9.Data.Entity
{
    public class Breed
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Cat's breed")]
        public string BreedName { get; set; } = default!;
        public ICollection<Cat> Cats { get; set; } = default!;



    }
}
