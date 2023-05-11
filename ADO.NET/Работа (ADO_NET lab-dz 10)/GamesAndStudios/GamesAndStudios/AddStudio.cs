using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameAndStudiosClasses;

namespace GamesAndStudios
{
    public partial class AddStudio : Form
    {
        public AddStudio()
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
                    Studios studios = new Studios(textBox1.Text);
                    context.Studios.Add(studios);
                    await context.SaveChangesAsync();
                }

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddGenre_Load(object sender, EventArgs e)
        {

        }
    }
}
