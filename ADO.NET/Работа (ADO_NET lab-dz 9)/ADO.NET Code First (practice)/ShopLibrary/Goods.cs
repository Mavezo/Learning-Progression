using Microsoft.EntityFrameworkCore;

namespace ShopLibrary
{
    public class Goods
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string Description { get; set; }

        public int TypeId { get; set; } 
        public GoodsTypes GoodsTypes { get; set; }  




    }
}