using ADO.NET_Code_First.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;

namespace ADO.NET_Code_First
{
    public partial class Form1 : Form
    {                               
        public Form1()      
        {
            InitializeComponent();
        }

        DbContextOptions<MyGamesContext> options;

        string connStr = "Data Source=MSI;Integrated Security=True;Initial Catalog=GamesTest;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
        private async void button1_Click(object sender, EventArgs e)
        {
            using (MyGamesContext context = new MyGamesContext(options))
            {
                Authors author1 = new Authors() { Name = "Valve" };
                Authors author2 = new Authors() { Name = "Аватар" };
                Authors author3 = new Authors() { Name = "Стим" };
                await context.Authors.AddRangeAsync(author1, author2, author3);
                await context.SaveChangesAsync();
                await context.Authors.LoadAsync();
                dataGridView1.DataSource = context.Authors.Select(t => new { t.Name, t.Id }).ToList();
                
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            using (MyGamesContext context = new MyGamesContext(options))
            {
                Games game1 = new Games() { Author = await context.Authors.FirstAsync(t => t.Id == 2), Name = "Dota 2", ReleaseDate = DateTime.Now };
                Games game2 = new Games() { Author = await context.Authors.FirstAsync(t => t.Id == 3), Name = "CS:GO", ReleaseDate = DateTime.Now };
                Games game3 = new Games() { Author = await context.Authors.FirstAsync(t => t.Id == 1), Name = "Trove", ReleaseDate = DateTime.Now };
                await context.Games.AddRangeAsync(game1, game2, game3);
                await context.SaveChangesAsync();
                await context.Games.LoadAsync();
                dataGridView1.DataSource = context.Games.Select(t => new { t.Name, t.Id, t.ReleaseDate, Author = t.Author.Name }).ToList();


            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DbContextOptionsBuilder<MyGamesContext> builder = new DbContextOptionsBuilder<MyGamesContext>();
            builder.UseSqlServer(connStr);
            builder.LogTo(message => Debug.WriteLine(message));
            options = builder.Options;



        }
    }
}