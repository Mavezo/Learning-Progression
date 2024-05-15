using ASP.NET_MVC_9.Data.Entity;
using ASP.NET_MVC_9.Models.DTO;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASP.NET_MVC_9.Models.CatViewModels
{
	public class IndexCatViewModel
	{
		public IEnumerable<CatDTO> Cats { get; set; } = default!;
		public SelectList BreedSL { get; set; } = default!;
		public int BreedId { get; set; }
		public string? Search { get; set; }


	}
}
