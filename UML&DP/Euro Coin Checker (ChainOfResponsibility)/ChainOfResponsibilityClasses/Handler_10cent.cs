using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityClasses
{
    public class Handler_10cent : Handler
    {

        public override decimal HandleRequest(decimal mass, decimal diameter)
        {

            if (mass > (decimal)4.09 && mass < (decimal)4.11)
            {
                if (diameter > (decimal)19.72 && diameter < (decimal)19.78)
                {
                    return (decimal)0.1;
                }
            }
            //if mass or diameter are wrong
            if (successer != null)
            {

                decimal temp;
                if ((temp = successer.HandleRequest(mass, diameter)) == 0)
                {
                    MessageBox.Show("Incorrect coin properties");
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

