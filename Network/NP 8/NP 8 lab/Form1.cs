using MimeKit;
using System.Net.Mail;
using System.Text;
using System.Text.Json;
using MailKit;
using MailKit.Net.Smtp;

namespace NP_8_lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Root? film;

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpRequestMessage requestMessage = new HttpRequestMessage())
                    {
                        requestMessage.Method = HttpMethod.Post;
                        requestMessage.RequestUri = new Uri($@"http://www.omdbapi.com/?apikey=594c4318&t={movieNameTextBox.Text}&type=movie");
                        HttpResponseMessage message = await client.SendAsync(requestMessage);
                        string content = await message.Content.ReadAsStringAsync();
                        film = JsonSerializer.Deserialize<Root>(content);
                        titleTextBox.Text = film.Title;
                        yearTextBox.Text = film.Year;
                        runtimeTextBox.Text = film.Runtime;
                        genresTextBox.Text = film.Genre;
                        directorTextBox.Text = film.Director;
                        imdbRatingTextBox.Text = film.imdbRating;
                        if (film.Ratings != null)
                        {
                            foreach (var rate in film?.Ratings)
                            {
                                if (rate.Source == "Internet Movie Database")
                                {
                                    internetMovieTextBox.Text = rate.Value;
                                }
                                if (rate.Source == "Rotten Tomatoes")
                                {
                                    rottenTomatoesTextBox.Text = rate.Value;
                                }
                                if (rate.Source == "Metacritic")
                                {
                                    metacriticTextBox.Text = rate.Value;
                                }
                            }
                        }
                        posterPictureBox.ImageLocation = $@"{film.Poster}";

                    }

                }
                if (!string.IsNullOrEmpty(titleTextBox.Text))
                {
                    button2.Enabled = true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            if (film != null)
            {
                if (!string.IsNullOrEmpty(friendMailTextBox.Text))
                {
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Roman Tselik", "mavezom@gmail.com"));
                    message.To.Add(new MailboxAddress("", friendMailTextBox.Text));
                    message.Subject = SubjectTextBox.Text;
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine($"Title: {film.Title}");
                    sb.AppendLine($"Year: {film.Year}");
                    sb.AppendLine($"Poster: {film.Poster}");
                    sb.AppendLine($"Awards: {film.Awards}");
                    sb.AppendLine($"BoxOffice: {film.BoxOffice}");
                    message.Body = new TextPart(MimeKit.Text.TextFormat.Plain) { Text = sb.ToString() };
                    using (var client = new MailKit.Net.Smtp.SmtpClient())
                    {
                        await client.ConnectAsync("smtp.gmail.com", 465, true);
                        await client.AuthenticateAsync("mavezom@gmail.com", "ycgjstudikbffvbh");
                        await client.SendAsync(message);
                        await client.DisconnectAsync(true);


                    }
                }
            }
        }
    }
}