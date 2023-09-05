using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityClasses
{
    public class Handler_1euro : Handler
    {

        public override decimal HandleRequest(decimal mass, decimal diameter)
        {
            if (mass > (decimal)7.49 && mass < (decimal)7.51)
            {
                if (diameter > (decimal)23.24 && diameter < (decimal)23.26)
                {
                    return 1;
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
