using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary
{
    public class MyGoodsContext  : DbContext
    {

        public DbSet<Goods> Goods { get; set; } = null;

        public DbSet<GoodsTypes> GoodsTypes { get; set; } = null;  


        public MyGoodsContext(DbContextOptions<MyGoodsContext> options) : base(options) {}

        public MyGoodsContext() { }

        


    }
}
