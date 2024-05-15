using Microsoft.EntityFrameworkCore;

namespace ASP.NET_MVC_QuestRoom.Data.Entity
{
    public class QuestRoomContext : DbContext
    {
        public DbSet<QuestRoom> QuestRooms { get; set; }
        public QuestRoomContext(DbContextOptions options) : base(options)
        {
        }
    }
}
