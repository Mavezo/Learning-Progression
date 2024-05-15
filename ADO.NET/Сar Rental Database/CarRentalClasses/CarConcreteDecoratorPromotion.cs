using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalClasses
{
    public class CarConcreteDecoratorPromotion : CarDecorator
    {
        public Promotion? currentPromotion { get; set; }
        public CarConcreteDecoratorPromotion(Promotion promotion, Car car) : base(car)
        {
            currentPromotion = promotion;
        }
        public CarConcreteDecoratorPromotion(Car car) : base(car) { }

        public void CalculatePromotion()
        {
            if (currentPromotion != null)
            {
                MaxDistance = MaxDistance + (MaxDistance / 100 * currentPromotion.IncreaseMaximumDistancePercent);
                CostOfRentingPerDay = CostOfRentingPerDay - (CostOfRentingPerDay / 100 * currentPromotion.DecreaseInRentalCostsPercent);
            }

        }

    }
}
