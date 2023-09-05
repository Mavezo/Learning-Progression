using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityClasses
{
    public abstract class Handler
    {
        public Handler successer { get; set; }
 
        public abstract decimal HandleRequest(decimal mass, decimal diameter);

    }
}
