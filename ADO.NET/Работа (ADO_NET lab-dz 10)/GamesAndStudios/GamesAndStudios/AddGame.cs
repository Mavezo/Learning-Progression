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
    public partial class AddGame : Form
    {
        public AddGame()
        {
            InitializeComponent();
        }

        private void AddGame_Load(object sender, EventArgs e)
        {
            using (GamesDbContext context = new GamesDbContext()) {
                comboBox1.DisplayMember= "Name";
                comboBox1.ValueMember= "Id";
                comboBox1.DataSource = context.Genres.ToList();
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "Id";
                comboBox2.DataSource= context.Studios.ToList();
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            using(GamesDbContext context = new GamesDbContext())
            {
                Games game = new Games() {
                    Name = textBox1.Text, 
                    Sales = int.Parse(numericUpDown1.Value.ToString()), 
                    Multiplayer = checkBox1.Checked, 
                    GenreId = int.Parse(comboBox1.SelectedValue.ToString()), 
                    StudioId = int.Parse(comboBox2.SelectedValue.ToString())
                };
                context.Games.Add(game);
                await context.SaveChangesAsync();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; 
        }
    }
}
