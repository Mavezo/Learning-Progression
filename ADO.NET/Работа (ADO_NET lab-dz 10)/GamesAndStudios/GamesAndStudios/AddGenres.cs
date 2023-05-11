using GameAndStudiosClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesAndStudios
{
    public partial class AddGenres : Form
    {
        public AddGenres()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                this.DialogResult = DialogResult.OK;
                using (GamesDbContext context = new GamesDbContext())
                {
                    Genres genres = new Genres(textBox1.Text);
                    context.Genres.Add(genres);
                    await context.SaveChangesAsync();
                }

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
