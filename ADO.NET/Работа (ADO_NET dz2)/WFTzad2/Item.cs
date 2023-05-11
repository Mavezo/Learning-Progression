using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTzad2
{
    public class Item
    {
        public string Name { get; set; }    
        public int IdType { get; set; } 
        public int Cost { get; set; }
        public Item(string name, int idType, int cost)
        {
            Name = name;
            IdType = idType;
            Cost = cost;
        }


    }
}
