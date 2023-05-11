using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Code_First.Models
{
    public class Games
    {
        public int Id { get; set; } 

        public DateTime ReleaseDate { get; set; }   

        public string Name { get; set; }

        public int AuthorId { get; set; }

        public Authors Author { get; set; } = null;

        //public int? RateFrom0To10 { get; set; }

    }
}
