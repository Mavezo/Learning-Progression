using Microsoft.Extensions.Configuration;
using ShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET_Code_First__practice_
{
    public partial class AddType : Form
    {
        public AddType()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            using (MyGoodsContext context = new MyContextShop().CreateDbContext(new string[0]))
            {
                GoodsTypes type = new GoodsTypes() { Name = textBox1.Text };
                await context.GoodsTypes.AddAsync(type);
                await context.SaveChangesAsync();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
