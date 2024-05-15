using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form2 : Form
    {
        Form1 form;
        public Form2(Form1 f)
        {
            InitializeComponent();
            form = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.label1.Text = $"Name: {textBox1.Text}, Surname: {textBox2.Text}, High: {textBox3.Text}";
        }
    }
}
