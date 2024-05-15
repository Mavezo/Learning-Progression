using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public class Item
    {

        public Item(string Name, string Creator, int Price)
        {
            name = Name;
            creator = Creator;
            price = Price;
        }
        string name;
        string creator;
        int price;

        public override string ToString()
        {
            return name + " " + creator;
        }
    }
}
