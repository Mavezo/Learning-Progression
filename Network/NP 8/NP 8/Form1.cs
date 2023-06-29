using MailKit;
using MimeKit;
using MailKit.Net.Smtp;

namespace NP_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Roman Tselik", "mavezom@gmail.com"));
            message.To.Add(new MailboxAddress("", mailTxtBox.Text));
            message.Subject = topicTextBox.Text;
            message.Body = new TextPart(MimeKit.Text.TextFormat.Plain) { Text = messageTextbox.Text };
            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.gmail.com", 465, true);
                await client.AuthenticateAsync("mavezom@gmail.com", "ycgjstudikbffvbh");
                await client.SendAsync(message);
                await client.DisconnectAsync(true);


            }



        }
    }
}