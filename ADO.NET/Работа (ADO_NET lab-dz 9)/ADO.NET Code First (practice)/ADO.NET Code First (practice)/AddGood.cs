using Microsoft.EntityFrameworkCore;
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
    public partial class AddGood : Form
    {
        public AddGood()
        {
            InitializeComponent();
        }

        private void AddGood_Load(object sender, EventArgs e)
        {
            using (MyGoodsContext context = new MyContextShop().CreateDbContext(new string[0]))
            {
                comboBox1.DataSource = context.GoodsTypes.ToList();
                comboBox1.DisplayMember= "Name";
                comboBox1.ValueMember= "Id";
                comboBox1.SelectedIndex = 0;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            using (MyGoodsContext context = new MyContextShop().CreateDbContext(new string[0]))
            {
                Goods good = new Goods() { Name = textBox1.Text, Description = textBox2.Text,  GoodsTypes = await context.GoodsTypes.FirstOrDefaultAsync(t=> t.Id == Convert.ToInt32(comboBox1.SelectedValue.ToString()))};
                await context.Goods.AddAsync(good);
                await context.SaveChangesAsync();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
