using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp4;

namespace WinFormsApp4
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item item = new Item(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text));
            form1.items.Add(item);
            form1.UpdateListBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
