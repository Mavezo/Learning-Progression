using System.ComponentModel.DataAnnotations;

namespace ASP.NET_MVC_QuestRoom.Data.Entity
{
    public class QuestRoom
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Quest Name")]
        public string QuestName { get; set; } = default!;
        public string Description { get; set; } = default!;
        [Required]
        [Display(Name = "Duration in minutes")]
        public int DurationInMinutes { get; set; }
        [Required]
        [Display(Name = "Min number of players")]
        public int MinOfPlayer { get; set; }
        [Required]
        [Display(Name = "Max number of players")]
        public int MaxOfPlayer { get; set; }
        [Required]
        public string Address { get; set; } = default!;
        [Required]
        [Display(Name = "PhoneNumber")]
        public string TelephoneNumber { get; set; } = default!;
        public string Company { get; set; } = default!;
        public Rate Rating { get; set; } = default!;
        [Display(Name = "Fear level")]
        public int FearLevel { get; set; }
        public int Difficulty { get; set; }
        [Display(Name = "Image name")]
        public string ImageName { get; set; } = default!;


        public enum Rate
        {
            Terrible,
            Bad,
            Poor,
            Fair,
            Good,
            Excellent
        }


    }
}
