using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        Form1 form;
        public Form2(Form1 f)
        {
            InitializeComponent();
            form = f;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            form.textBox1.Text = textBox1.Text;
           
        }
    }
}
