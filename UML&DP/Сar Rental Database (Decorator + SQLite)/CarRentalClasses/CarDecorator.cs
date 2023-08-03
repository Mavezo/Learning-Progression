using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalClasses
{
    public class CarDecorator : Car
    {
        public CarDecorator(Car car) : base(car)
        {
        }
    }
}
