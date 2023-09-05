using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityClasses
{
    public class Handler_50cent : Handler
    {

        public override decimal HandleRequest(decimal mass, decimal diameter)
        {
            if (mass > (decimal)7.79 && mass < (decimal)7.81)
            {
                if (diameter > (decimal)24.24 && diameter < (decimal)24.26)
                {
                    return (decimal)0.5;
                }
            }
            //if mass or diameter are wrong
            if (successer != null)
            {

                decimal temp;
                if ((temp = successer.HandleRequest(mass, diameter)) == 0)
                {
                    return 0;
                }
                else
                {
                    return temp;
                }
            }
            return 0;
        }
    }
}
