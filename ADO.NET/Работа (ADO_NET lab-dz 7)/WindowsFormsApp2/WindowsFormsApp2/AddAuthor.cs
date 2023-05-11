using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AddAuthor : Form
    {
        public AddAuthor()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            using (BooksEntities context = new BooksEntities())
            {
                Author author = new Author() { Firstname = textBox1.Text, Surname = textBox2.Text, YearOfBirth = monthCalendar1.SelectionStart };
                context.Authors.Add(author);
                await context.SaveChangesAsync();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
