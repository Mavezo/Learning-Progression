using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalClasses
{
    public class Promotion
    {
        public int Id { get; set; }
        public DateTime StartDateOfPromotion { get; set; } 
        public DateTime EndDateOfPromotion { get; set; }
        public string NameOfPromotion { get; set; } = null!;
        public int DecreaseInRentalCostsPercent { get; set; }
        public int IncreaseMaximumDistancePercent { get; set; }


    }
}
