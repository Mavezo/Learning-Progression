using Microsoft.EntityFrameworkCore;
using ShopLibrary;
using ShopLibrary.Migrations;

namespace ADO.NET_Code_First__practice_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddGood form = new AddGood();
            if(form.ShowDialog() == DialogResult.OK) 
            {
                button2_Click(sender, e);
            }
        }   

        private void Form1_Load(object sender, EventArgs e)
        {
         

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddType form = new AddType();
            if (form.ShowDialog() == DialogResult.OK)
            {
                button4_Click(sender, e);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (MyGoodsContext context = new MyContextShop().CreateDbContext(new string[0]))
            {
                dataGridView1.DataSource = null; 
                dataGridView1.DataSource = context.GoodsTypes.Select(t=> new { t.Id, t.Name}).ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MyGoodsContext context = new MyContextShop().CreateDbContext(new string[0]))
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = context.Goods.Select(t => new { t.Id, t.Name, t.Description, Type = t.GoodsTypes.Name }).ToList();


            }
        }
    }
}