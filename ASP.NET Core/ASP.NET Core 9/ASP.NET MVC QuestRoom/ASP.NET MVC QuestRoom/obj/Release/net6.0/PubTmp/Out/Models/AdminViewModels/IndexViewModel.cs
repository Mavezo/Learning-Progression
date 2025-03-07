using ASP.NET_MVC_QuestRoom.Data.Entity;

namespace ASP.NET_MVC_QuestRoom.Models.AdminViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<QuestRoom> Rooms { get; set; } = default!;
        public PageViewModel PageViewModel { get; set; } = default!;
        public string? Search { get; set; }

    }
}
