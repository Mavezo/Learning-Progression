namespace GameAndStudiosClasses
{
    public class Games
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Sales { get; set; }
        public bool Multiplayer { get; set; }
        public int StudioId { get; set; }
        public virtual Studios? Studio { get; set; } 
        public int GenreId {get; set; }
        public virtual Genres? Genre { get; set; }  
    }
}