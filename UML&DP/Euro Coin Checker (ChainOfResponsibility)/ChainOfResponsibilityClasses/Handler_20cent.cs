using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityClasses
{
    public class Handler_20cent : Handler
    {

        public override decimal HandleRequest(decimal mass, decimal diameter)
        {
            if (mass > (decimal)5.73 && mass < (decimal)5.75)
            {
                if (diameter > (decimal)22.24 && diameter < (decimal)22.26)
                {
                    return (decimal)0.2;
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
