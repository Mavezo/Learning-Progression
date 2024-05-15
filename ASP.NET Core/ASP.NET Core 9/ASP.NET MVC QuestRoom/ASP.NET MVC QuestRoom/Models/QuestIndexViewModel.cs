using ASP.NET_MVC_QuestRoom.Data.Entity;

namespace ASP.NET_MVC_QuestRoom.Models
{
	public class QuestIndexViewModel
	{
		public IEnumerable<QuestRoom> Rooms { get; set; } = default!;
		public string? Search { get; set; }

	}
}
