using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Code_First.Models
{
    public class Authors
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Games> Games { get; set; }

        public Authors()
        {
            Games = new HashSet<Games>();
        }



    }
}
