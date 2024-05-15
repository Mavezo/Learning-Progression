using ASP.NET_MVC_QuestRoom.Data.Entity;

namespace ASP.NET_MVC_QuestRoom.Models.AdminViewModels
{
	public class CreateViewModel
	{
		public QuestRoom QuestRoom { get; set; }
		public IFormFile Image { get; set; }
	}
}
