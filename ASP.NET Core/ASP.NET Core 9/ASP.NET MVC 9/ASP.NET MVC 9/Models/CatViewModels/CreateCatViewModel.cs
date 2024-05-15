using ASP.NET_MVC_9.Models.DTO;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASP.NET_MVC_9.Models.CatViewModels
{
	public class CreateCatViewModel
	{
		public CatDTO Cat { get; set; } = default!;
		public SelectList? BreedSL { get; set; } = default!;
		public IFormFile Image { get; set; } = default!;
	}
}
