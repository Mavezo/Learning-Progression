using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary
{
    public class GoodsTypes
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Goods> Goods { get; set; } = null;
        public GoodsTypes()
        {
            Goods = new HashSet<Goods>();
        }

    }
}
