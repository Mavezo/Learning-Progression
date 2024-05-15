using Microsoft.EntityFrameworkCore;

namespace ASP.NET_MVC_QuestRoom.Data.Entity
{
    public static class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            DbContextOptions<QuestRoomContext> options = serviceProvider.GetRequiredService<DbContextOptions<QuestRoomContext>>();
            using (QuestRoomContext context = new QuestRoomContext(options))
            {
				//context.Database.EnsureDeleted();
				context.Database.EnsureCreated();
                if (!context.QuestRooms.Any())
                {
					QuestRoom horrorRoom = new QuestRoom()
					{
						Address = "Dark Alley, 13",
						Company = "Fearful Adventures",
						Description = "Face your deepest fears in this horror-themed quest room.",
						Difficulty = 3,
						DurationInMinutes = 45,
						FearLevel = 5,
                        ImageName = $"horrorRoom.png",
						MaxOfPlayer = 6,
						MinOfPlayer = 3,
						QuestName = "Horror Nightmare",
						Rating = QuestRoom.Rate.Good,
						TelephoneNumber = "555-666-777"
					};
					QuestRoom kidsRoom = new QuestRoom()
					{
						Address = "123 Play Street",
						Company = "KidQuest Fun",
						Description = "A delightful quest room designed for children, full of puzzles and magic.",
						Difficulty = 1,
						DurationInMinutes = 30,
						FearLevel = 0,
						ImageName = $"kidsRoom.png",
						MaxOfPlayer = 5,
						MinOfPlayer = 2,
						QuestName = "Magic Adventure",
						Rating = QuestRoom.Rate.Excellent,
						TelephoneNumber = "123-456-789"
					};
					QuestRoom detectiveRoom = new QuestRoom()
					{
						Address = "Mystery Mansion, 7",
						Company = "Sleuth Solutions",
						Description = "Unravel the mystery in this detective-themed quest room filled with clues and puzzles.",
						Difficulty = 2,
						DurationInMinutes = 60,
						FearLevel = 1,
						ImageName = "detectiveRoom.png",
						MaxOfPlayer = 8,
						MinOfPlayer = 4,
						QuestName = "Mansion Mystery",
						Rating = QuestRoom.Rate.Good,
						TelephoneNumber = "987-654-321"
					};
					QuestRoom teamBuildingRoom = new QuestRoom()
					{
						Address = "Team Challenge Center",
						Company = "Teamwork Adventures",
						Description = "Enhance team spirit with challenging puzzles and collaborative tasks.",
						Difficulty = 3,
						DurationInMinutes = 90,
						FearLevel = 0,
						ImageName = $"teamBuildingRoom.png",
						MaxOfPlayer = 10,
						MinOfPlayer = 6,
						QuestName = "Team Quest Challenge",
						Rating = QuestRoom.Rate.Fair,
						TelephoneNumber = "111-222-333"
					};
					QuestRoom fantasyRoom = new QuestRoom()
					{
						Address = "Realm of Enchantment, 42",
						Company = "Fantasy Escapes",
						Description = "Embark on a magical journey through this fantasy-themed quest room with mystical puzzles.",
						Difficulty = 4,
						DurationInMinutes = 75,
						FearLevel = 2,
						ImageName = $"fantasyRoom.png",
						MaxOfPlayer = 6,
						MinOfPlayer = 3,
						QuestName = "Enchanted Realm",
						Rating = QuestRoom.Rate.Good,
						TelephoneNumber = "777-888-999"
					};
					QuestRoom sciFiRoom = new QuestRoom()
					{
						Address = "Space Lab 3000",
						Company = "Sci-Fi Adventures",
						Description = "Explore the wonders of the future in this sci-fi-themed quest room with high-tech puzzles.",
						Difficulty = 3,
						DurationInMinutes = 60,
						FearLevel = 1,
						ImageName = $"sciFiRoom.png",
						MaxOfPlayer = 5,
						MinOfPlayer = 2,
						QuestName = "Space Odyssey",
						Rating = QuestRoom.Rate.Excellent,
						TelephoneNumber = "234-567-890"
					};
					QuestRoom adventureRoom = new QuestRoom()
					{
						Address = "Explorer's Cove, 55",
						Company = "Adventurous Expeditions",
						Description = "Embark on a thrilling adventure in this quest room filled with challenges and excitement.",
						Difficulty = 4,
						DurationInMinutes = 60,
						FearLevel = 3,
						ImageName = $"adventureRoom.png",
						MaxOfPlayer = 7,
						MinOfPlayer = 4,
						QuestName = "Jungle Expedition",
						Rating = QuestRoom.Rate.Excellent,
						TelephoneNumber = "789-012-345"
					};
					QuestRoom historicalRoom = new QuestRoom()
					{
						Address = "Time Travel Plaza, 8",
						Company = "History Mysteries",
						Description = "Travel through time and solve historical mysteries in this educational quest room.",
						Difficulty = 2,
						DurationInMinutes = 45,
						FearLevel = 0,
						ImageName = $"historicalRoom.png",
						MaxOfPlayer = 6,
						MinOfPlayer = 2,
						QuestName = "Time Warp Chronicles",
						Rating = QuestRoom.Rate.Good,
						TelephoneNumber = "456-789-012"
					};
					QuestRoom pirateRoom = new QuestRoom()
					{
						Address = "Pirate's Cove, 23",
						Company = "Swashbuckling Adventures",
						Description = "Set sail on a pirate-themed quest room and search for hidden treasures on the high seas.",
						Difficulty = 3,
						DurationInMinutes = 50,
						FearLevel = 1,
						ImageName = $"pirateRoom.png",
						MaxOfPlayer = 8,
						MinOfPlayer = 4,
						QuestName = "Treasure Hunt Ahoy!",
						Rating = QuestRoom.Rate.Fair,
						TelephoneNumber = "890-123-456"
					};
					QuestRoom spaceRoom = new QuestRoom()
					{
						Address = "Galactic Gateway, 99",
						Company = "Interstellar Adventures",
						Description = "Embark on an intergalactic journey in this space-themed quest room with cosmic challenges.",
						Difficulty = 4,
						DurationInMinutes = 75,
						FearLevel = 2,
						ImageName = $"spaceRoom.png",
						MaxOfPlayer = 5,
						MinOfPlayer = 3,
						QuestName = "Galactic Explorer",
						Rating = QuestRoom.Rate.Excellent,
						TelephoneNumber = "321-654-987"
					};
					QuestRoom sportsRoom = new QuestRoom()
					{
						Address = "Sports Arena, 12",
						Company = "Athletic Challenges",
						Description = "Test your sports knowledge and skills in this adrenaline-pumping sports-themed quest room.",
						Difficulty = 2,
						DurationInMinutes = 40,
						FearLevel = 0,
						ImageName = $"sportsRoom.png",
						MaxOfPlayer = 4,
						MinOfPlayer = 2,
						QuestName = "Sports Fanatic Challenge",
						Rating = QuestRoom.Rate.Good,
						TelephoneNumber = "555-123-456"
					};
					///////
					QuestRoom underwaterRoom = new QuestRoom()
					{
						Address = "Ocean Depths, 25",
						Company = "Aquatic Adventures",
						Description = "Dive into the mysteries of the ocean in this underwater-themed quest room with marine puzzles.",
						Difficulty = 3,
						DurationInMinutes = 60,
						FearLevel = 2,
						ImageName = $"underwaterRoom.png",
						MaxOfPlayer = 6,
						MinOfPlayer = 3,
						QuestName = "Ocean Odyssey",
						Rating = QuestRoom.Rate.Good,
						TelephoneNumber = "999-888-777"
					};
					QuestRoom spyRoom = new QuestRoom()
					{
						Address = "Secret Agent Headquarters, 007",
						Company = "Covert Operations",
						Description = "Step into the world of espionage in this spy-themed quest room with covert missions and hidden clues.",
						Difficulty = 4,
						DurationInMinutes = 75,
						FearLevel = 1,
						ImageName = $"spyRoom.png",
						MaxOfPlayer = 5,
						MinOfPlayer = 3,
						QuestName = "Operation Stealth",
						Rating = QuestRoom.Rate.Excellent,
						TelephoneNumber = "007-123-456"
					};
					QuestRoom culinaryRoom = new QuestRoom()
					{
						Address = "Gourmet Kitchen, 50",
						Company = "Culinary Quests",
						Description = "Cook up a storm in this culinary-themed quest room, solving food-related puzzles and challenges.",
						Difficulty = 2,
						DurationInMinutes = 45,
						FearLevel = 0,
						ImageName = $"culinaryRoom.png",
						MaxOfPlayer = 4,
						MinOfPlayer = 2,
						QuestName = "Chef's Challenge",
						Rating = QuestRoom.Rate.Good,
						TelephoneNumber = "789-456-123"
					};
					QuestRoom musicRoom = new QuestRoom()
					{
						Address = "Melody Manor, 15",
						Company = "Harmonic Adventures",
						Description = "Immerse yourself in the world of music in this melodious quest room with musical puzzles and challenges.",
						Difficulty = 3,
						DurationInMinutes = 60,
						FearLevel = 0,
						ImageName = $"musicRoom.png",
						MaxOfPlayer = 6,
						MinOfPlayer = 3,
						QuestName = "Symphony Quest",
						Rating = QuestRoom.Rate.Excellent,
						TelephoneNumber = "345-678-901"
					};
					QuestRoom superheroRoom = new QuestRoom()
					{
						Address = "Hero Haven, 30",
						Company = "Superhero Adventures",
						Description = "Become a superhero in this action-packed quest room with challenges and missions to save the day.",
						Difficulty = 4,
						DurationInMinutes = 75,
						FearLevel = 1,
						ImageName = $"superheroRoom.png",
						MaxOfPlayer = 5,
						MinOfPlayer = 2,
						QuestName = "Heroic Pursuit",
						Rating = QuestRoom.Rate.Excellent,
						TelephoneNumber = "678-901-234"
					};
					QuestRoom mysticRoom = new QuestRoom()
					{
						Address = "Mystic Sanctuary, 18",
						Company = "Ancient Riddles",
						Description = "Uncover ancient mysteries in this mystic-themed quest room with puzzles steeped in magic and mysticism.",
						Difficulty = 3,
						DurationInMinutes = 60,
						FearLevel = 2,
						ImageName = $"mysticRoom.png",
						MaxOfPlayer = 5,
						MinOfPlayer = 3,
						QuestName = "Enigmatic Enchantment",
						Rating = QuestRoom.Rate.Good,
						TelephoneNumber = "123-345-567"
					};
					QuestRoom artGalleryRoom = new QuestRoom()
					{
						Address = "Canvas Conundrum, 22",
						Company = "Artistic Adventures",
						Description = "Immerse yourself in the world of art in this gallery-themed quest room with artistic puzzles and challenges.",
						Difficulty = 2,
						DurationInMinutes = 50,
						FearLevel = 0,
						ImageName = $"artGalleryRoom.png",
						MaxOfPlayer = 6,
						MinOfPlayer = 4,
						QuestName = "Gallery Escape",
						Rating = QuestRoom.Rate.Fair,
						TelephoneNumber = "234-567-890"
					};
					QuestRoom wildWestRoom = new QuestRoom()
					{
						Address = "Frontier Town, 33",
						Company = "Western Adventures",
						Description = "Step back in time to the Wild West in this frontier-themed quest room with cowboy puzzles and challenges.",
						Difficulty = 3,
						DurationInMinutes = 60,
						FearLevel = 1,
						ImageName = $"wildWestRoom.png",
						MaxOfPlayer = 7,
						MinOfPlayer = 4,
						QuestName = "Outlaw Pursuit",
						Rating = QuestRoom.Rate.Good,
						TelephoneNumber = "789-012-345"
					};
					QuestRoom aviationRoom = new QuestRoom()
					{
						Address = "Sky High Hangar, 29",
						Company = "Aviation Adventures",
						Description = "Take flight in this aviation-themed quest room with challenges and puzzles inspired by the world of airplanes.",
						Difficulty = 4,
						DurationInMinutes = 75,
						FearLevel = 2,
						ImageName = $"aviationRoom.png",
						MaxOfPlayer = 5,
						MinOfPlayer = 3,
						QuestName = "Sky Captain's Challenge",
						Rating = QuestRoom.Rate.Excellent,
						TelephoneNumber = "345-678-901"
					};
					QuestRoom technologyRoom = new QuestRoom()
					{
						Address = "Tech Tower, 11",
						Company = "Tech Savvy Quests",
						Description = "Explore the cutting-edge world of technology in this quest room with high-tech puzzles and challenges.",
						Difficulty = 3,
						DurationInMinutes = 60,
						FearLevel = 0,
						ImageName = $"technologyRoom.png",
						MaxOfPlayer = 6,
						MinOfPlayer = 3,
						QuestName = "Tech Explorer",
						Rating = QuestRoom.Rate.Good,
						TelephoneNumber = "567-890-123"
					};

					context.QuestRooms.AddRange(horrorRoom, kidsRoom, detectiveRoom, fantasyRoom, sciFiRoom, teamBuildingRoom, adventureRoom, sportsRoom, spaceRoom, pirateRoom, historicalRoom);
					context.QuestRooms.AddRange(underwaterRoom, spyRoom, culinaryRoom, musicRoom, superheroRoom, mysticRoom, artGalleryRoom, wildWestRoom, technologyRoom);
                    context.SaveChanges();
                }
            }
        }
    }
}
