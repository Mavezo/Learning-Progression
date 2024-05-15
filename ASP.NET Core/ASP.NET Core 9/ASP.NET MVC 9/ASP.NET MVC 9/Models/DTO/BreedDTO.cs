using ASP.NET_MVC_9.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_MVC_9.Models.DTO
{
	public class BreedDTO
	{
		public int Id { get; set; }
		[Required]
		[DisplayName("Cat's breed")]
		public string BreedName { get; set; } = default!;
		public ICollection<CatDTO> Cats { get; set; } = default!;

	}
}
