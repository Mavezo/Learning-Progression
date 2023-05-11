using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (BooksEntities context = new BooksEntities())
            {
                context.Authors.Load();
                var authors = context.Authors.Local;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = authors.Select(t => new { t.Id, t.Firstname, t.Surname, t.YearOfBirth }).ToList(); ;

                context.SaveChanges();
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            using (BooksEntities context = new BooksEntities())
            {
                await context.Books.LoadAsync();
                var books = context.Books.Local.Select(t => new {t.Id, t.Title, Author = t.Author.Firstname + "" + t.Author.Surname, t.YearOfPublish});
                dataGridView1.DataSource = null;
                dataGridView1.DataSource= books.ToList();



            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            int authorId;
            if(dataGridView1.SelectedRows.Count > 0)
            {
                if (int.TryParse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString(), out authorId)){
                    using(var context = new BooksEntities())
                    {
                        Author selectedAuthor = await context.Authors.FirstOrDefaultAsync(t=> t.Id == authorId);      
                        if(selectedAuthor != null) 
                        {
                            var books = selectedAuthor.Books.ToList();
                            listBox1.DataSource = null;
                            listBox1.DisplayMember= "Title";
                            listBox1.DataSource = books;
                            
                        }


                    } 


                }


            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            AddAuthor form2 = new AddAuthor();
            if(form2.ShowDialog() == DialogResult.OK)
            {
                using (var context = new BooksEntities()) 
                {
                    var authors = context.Authors.Select(t => new {t.Id, t.Firstname, t.Surname, t.YearOfBirth }).ToList();
                    dataGridView1.DataSource = authors;
                }

            }



            //using(BooksEntities context = new BooksEntities())
            //{
            //    //Author author = await context.Authors.FirstOrDefaultAsync(t=> t.Firstname == "Analtoylij");
            //    //context.Authors.Remove(author);
            //    if (context.Authors.FirstOrDefault(t => t.Firstname == "Analtoylij") == null)
            //    {
            //        Author author = new Author { Firstname = "Analtoylij", Surname = "Tomski", YearOfBirth = DateTime.Today };
            //        context.Authors.Add(author);
            //    }
            //    await context.SaveChangesAsync();
            //    context.Authors.Load();
            //    var authors = context.Authors.Select(t=> new { Name = t.Firstname + " " + t.Surname, t.YearOfBirth }).ToList();
            //    dataGridView1.DataSource = authors;
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteAuthor form3 = new DeleteAuthor(); 
            if(form3.ShowDialog() == DialogResult.OK)
            {
                using (BooksEntities context = new BooksEntities())
                {
                    var authors = context.Authors.Select(t => new { t.Id, t.Firstname, t.Surname, t.YearOfBirth }).ToList();
                    dataGridView1.DataSource = authors;
                }
            }
        }
    }
}
