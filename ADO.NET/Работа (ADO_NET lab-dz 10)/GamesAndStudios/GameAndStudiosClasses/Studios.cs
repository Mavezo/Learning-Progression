using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAndStudiosClasses
{
    public class Studios
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public virtual List<Games> Games { get; set; }

        public Studios() { 
        Games= new List<Games>();
        }
        public Studios(string name) 
        {
            Games = new List<Games>();
            this.Name = name;
        }

    }
}
