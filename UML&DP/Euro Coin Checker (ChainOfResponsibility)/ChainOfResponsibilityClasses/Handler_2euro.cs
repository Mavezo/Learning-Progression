using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityClasses
{
    public class Handler_2euro : Handler
    {

        public override decimal HandleRequest(decimal mass, decimal diameter)
        {
            if (mass > (decimal)8.49 && mass < (decimal)8.51)
            {
                if (diameter > (decimal)25.74 && diameter < (decimal)25.76)
                {
                    return 2;
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
