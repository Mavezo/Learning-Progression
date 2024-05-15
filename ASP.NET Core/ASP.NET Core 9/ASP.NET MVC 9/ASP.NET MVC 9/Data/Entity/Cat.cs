using System.ComponentModel.DataAnnotations;

namespace ASP.NET_MVC_9.Data.Entity
{
    public class Cat
    {
        public int Id { get; set; }
        [Required]
        public string CatName { get; set; } = default!;
        public string? Description { get; set; }
        [Required]
        public string CatGender { get; set; } = default!;
        public bool IsVacinated { get; set; }
        public byte[]? Image { get; set; }
        public bool IsDeleted { get; set; }
        
        public int BreedId { get; set; }
        public Breed? Breed { get; set; }    


    }


}
