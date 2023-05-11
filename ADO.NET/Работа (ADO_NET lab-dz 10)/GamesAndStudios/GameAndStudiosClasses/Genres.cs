using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAndStudiosClasses
{
    public class Genres
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Games> Games { get; set; } 

        public Genres(string name)
        {
            Games = new List<Games>();
            this.Name = name;
        }
        public Genres()
        {
            Games = new List<Games>();
        }
    }
}
