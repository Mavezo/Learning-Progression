using GameAndStudiosClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Microsoft.VisualBasic.Devices;

namespace GamesAndStudios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            using (GamesDbContext context = new GamesDbContext())
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = context.Studios.Select(t => new { t.Id, t.Name }).ToList();
                textBox1.Text = context.log.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (GamesDbContext context = new GamesDbContext())
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = context.Genres.Select(t => new { t.Id, t.Name }).ToList();
                textBox1.Text = context.log.ToString();
            }
        }
        private async void button3_Click(object sender, EventArgs e)
        {
            using (GamesDbContext context = new GamesDbContext())
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = await context.Games.Select(t => new { t.Id, t.Name, Multiplayer = t.Multiplayer.ToString(), StudioName = t.Studio.Name, GenreName = t.Genre.Name }).ToListAsync();
                textBox1.Text = context.log.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddStudio form = new AddStudio();
            if (form.ShowDialog() == DialogResult.OK)
            {
                button1_Click(sender, e);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddGenres form = new AddGenres();
            if (form.ShowDialog() == DialogResult.OK)
            {
                button2_Click(sender, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddGame form = new AddGame();
            if (form.ShowDialog() == DialogResult.OK)
            {
                button3_Click(sender, e);
            }
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                using (GamesDbContext context = new GamesDbContext())
                {
                    Studios studio = await context.Studios.FirstOrDefaultAsync(t => t.Id == int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                    if (studio != null)
                    {
                        context.Studios.Remove(studio);
                        await context.SaveChangesAsync();
                        button1_Click(sender, e);
                    }
                }
            }
        }
        private async void button9_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                using (GamesDbContext context = new GamesDbContext())
                {
                    Genres genre = await context.Genres.FirstOrDefaultAsync(t => t.Id == int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                    if (genre != null)
                    {
                        context.Genres.Remove(genre);
                        await context.SaveChangesAsync();
                        button2_Click(sender, e);
                    }
                }
            }
        }
        private async void button10_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                using (GamesDbContext context = new GamesDbContext())
                {
                    Games game = await context.Games.FirstOrDefaultAsync(t => t.Id == int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                    if (game != null)
                    {
                        context.Games.Remove(game);
                        await context.SaveChangesAsync();
                        button3_Click(sender, e);
                    }
                }
            }
        }
        private async void button10_Click_1(object sender, EventArgs e)
        {
            using (GamesDbContext context = new GamesDbContext())
            {
                await context.Studios.Include(t => t.Games).LoadAsync();
                var temp = context.Studios.Where(t => t.Games.Count > 0).Select(t => new { t.Name, t.Games.Count }).OrderByDescending(t => t.Count).ToList();
                List<Object> studios = new List<Object>();
                int i = 0;
                foreach (var studio in temp)
                {
                    if (i < 3)
                    {
                        studios.Add(studio);
                        i++;
                    }
                    else
                    {
                        break;
                    }

                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = studios;
                textBox1.Text = context.log.ToString();

            }
        }
        private async void button11_Click(object sender, EventArgs e)
        {
            using (GamesDbContext context = new GamesDbContext())
            {
                await context.Studios.Include(t => t.Games).LoadAsync();
                var temp = context.Studios.Where(t => t.Games.Count > 0).Select(t => new { t.Name, t.Games.Count }).OrderByDescending(t => t.Count).ToList();
                List<Object> studios = new List<Object>();
                studios.Add(temp[0]);    
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = studios;
                textBox1.Text = context.log.ToString();
            }
        }
        private async void button12_Click(object sender, EventArgs e)
        {
            using (GamesDbContext context = new GamesDbContext())
            {
                List<Object> genres = new List<Object>();
                await context.Genres.Include(t => t.Games).LoadAsync();
                var temp = await context.Genres.Select(t => new { t.Name, t.Games.Count }).OrderByDescending(t => t.Count).ToListAsync();
                int i = 0;
                foreach (var item in temp)
                {
                    if(i < 3)
                    { 
                        genres.Add(item);
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = genres;
                textBox1.Text = context.log.ToString();
            }
        }

        private async void button13_Click(object sender, EventArgs e)
        {
            using (GamesDbContext context = new GamesDbContext())
            {
                await context.Genres.Include(t=> t.Games).LoadAsync();
                var temp = await context.Genres.Where(t => t.Games.Count > 0)
                    .Select(t => new { t.Name, t.Games.Count })
                    .OrderByDescending(t => t.Count).ToListAsync();
                List<Object> list = new List<Object>();
                list.Add(temp[0]);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = list;
                textBox1.Text = context.log.ToString();
            }
        }

        private async void button14_Click(object sender, EventArgs e)
        {
            using (GamesDbContext context = new GamesDbContext())
            {
                await context.Genres.Include(t=> t.Games).LoadAsync();
                var temp = await context.Genres.Select(t => new { t.Name, SumOfSales = t.Games.Sum(t => t.Sales) })
                    .OrderByDescending(t => t.SumOfSales).ToListAsync();
                List<Object> genres = new List<Object>();
                int i = 0;
                foreach (var genre in temp)
                {
                    if (i < 3)
                    {
                        genres.Add(genre);
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = genres;
                textBox1.Text = context.log.ToString();
            }
        }

        private async void button15_Click(object sender, EventArgs e)
        {
            using(GamesDbContext context = new GamesDbContext())
            {
                await context.Genres.Include(t => t.Games).LoadAsync();
                var temp = await context.Genres.Where(t=> t.Games.Count > 0)
                    .Select(t=> new { t.Name, SumOfSales = t.Games.Sum(t=> t.Sales) })
                    .OrderByDescending(t=>t.SumOfSales).ToListAsync();
                List<object> list = new List<object>();
                list.Add(temp[0]);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = list;
                textBox1.Text = context.log.ToString();
            }
        }

        private async void button17_Click(object sender, EventArgs e)
        {
            using (GamesDbContext context = new GamesDbContext())
            {
                var games = await context.Games.Where(t => t.Multiplayer == false)
                 .Select(t => new { t.Name, t.Sales, Multiplayer = t.Multiplayer.ToString() })
                 .OrderByDescending(t => t.Sales).ToListAsync();
                List <Object> list = new List<Object>();
                int i = 0;
                foreach (var item in games)
                {
                    if(i < 3)
                    {
                        list.Add(item);
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = list;
                textBox1.Text = context.log.ToString();



            }
        }

        private async void button16_Click(object sender, EventArgs e)
        {
            using(GamesDbContext context= new GamesDbContext())
            {
                var games = await context.Games.Where(t=>t.Multiplayer == true)
                    .Select(t => new {t.Name, t.Sales})
                    .OrderByDescending(t => t.Sales).ToListAsync();
                List<Object> list = new List<Object>(); 
                int i = 0;
                foreach (var item in games)
                {
                    if(i <3) { 
                        list.Add(item); 
                        i++;
                    
                    }
                    else
                    {
                         break;
                    }
                }
                dataGridView1.DataSource= null;
                dataGridView1.DataSource = list;
                textBox1.Text = context.log.ToString();





            }
        }

        private async void button18_Click(object sender, EventArgs e)
        {
            using (GamesDbContext context = new GamesDbContext())
            {
                var temp = await context.Games.Where(t => t.Multiplayer == false)
                    .Select(t => new { t.Name, t.Sales, Multiplayer = t.Multiplayer.ToString()}).OrderByDescending(t => t.Sales).ToListAsync();
                List<object> list= new List<object>();
                list.Add(temp[0]);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = list;
                textBox1.Text = context.log.ToString();

            }
        }

        private async void button19_Click(object sender, EventArgs e)
        {
            using(GamesDbContext context = new GamesDbContext())
            {
                var temp = await context.Games.Where(t => t.Multiplayer == true)
                    .Select(t => new { t.Name, t.Sales, Multiplayer = t.Multiplayer.ToString() })
                    .OrderByDescending(t => t.Sales).ToListAsync();
                List<object> list = new List<object>();
                list.Add(temp[0]);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = list;
                textBox1.Text = context.log.ToString();
            }


        }
    }
}