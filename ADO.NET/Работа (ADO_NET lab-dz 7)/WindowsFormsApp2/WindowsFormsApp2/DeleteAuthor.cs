using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class DeleteAuthor : Form
    {
        public DeleteAuthor()
        {
            InitializeComponent();
        }

        private void DeleteAuthor_Load(object sender, EventArgs e)
        {
            using (BooksEntities context = new BooksEntities())
            {
                context.Authors.Load();
                var authors = context.Authors.Local.Select(t=> new { t.Id, Fullname = t.Firstname + " " + t.Surname, t.YearOfBirth}).ToList();
                comboBox1.DataSource = authors;
                comboBox1.DisplayMember = "Fullname";

            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
      
            using (BooksEntities context = new BooksEntities())
            {
                var author = await context.Authors.FirstOrDefaultAsync(t => (t.Firstname + " " + t.Surname) == comboBox1.Text);
                if (author != null) 
                {
                    context.Authors.Remove(author);
                    await context.SaveChangesAsync();
                }

            }
            this.DialogResult = DialogResult.OK;




        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
