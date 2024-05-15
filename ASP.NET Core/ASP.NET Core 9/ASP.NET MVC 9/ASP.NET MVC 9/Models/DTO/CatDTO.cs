using ASP.NET_MVC_9.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_MVC_9.Models.DTO
{
	public class CatDTO
	{
		public int Id { get; set; }
		[Required]
		[Display(Name = "Cat's name")]
		public string CatName { get; set; } = default!;
		public string? Description { get; set; }
		[Required]
        [Display(Name = "Cat's gender")]
        public CatGender CatGender { get; set; }
		[Display(Name = "Status of Vacination")]
		public bool IsVacinated { get; set; }
		public byte[]? Image { get; set; }
        [Display(Name = "Cat's breed")]
        public int BreedId { get; set; }
		public BreedDTO? Breed { get; set; }

	}
}
