using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP_3___ADO.NET__dz__value_work.Models
{
    [Serializable()]
    public class Prices
    {
        public int Id { get; set; }

        public int HardwareId { get; set; }
        public virtual Hardware? Hardware { get; set; } = null;
        public int Price { get; set; }


        public Prices() { }

    }
}
