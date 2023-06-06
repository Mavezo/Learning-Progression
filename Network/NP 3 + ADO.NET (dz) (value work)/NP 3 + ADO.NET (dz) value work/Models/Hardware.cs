using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NP_3___ADO.NET__dz__value_work.Models
{
    [Serializable()]
    public class Hardware
    {
        public int Id { get; set; }
        public string Name { get; set; } 

        public Hardware(string name)
        {
            Name = name;
        }

        [JsonConstructor]
        public Hardware() { }   
    

        public override string ToString()
        {
            return $"{Name} (ID: {Id})";
        }

    }
}
