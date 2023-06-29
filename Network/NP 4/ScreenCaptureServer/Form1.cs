using System.Net;
using System.Net.Sockets;
using System.Text;
using ScreenCaptureClient;
using ScreenSaver;
using ScreenCaptureServer;

namespace ScreenCaptureServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Task task = null;
        TcpClient client;
        IPEndPoint clientPoint;
        IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse("192.168.0.28"), 11001);
        private void button1_Click(object sender, EventArgs e)
        {
                timer1.Interval = int.Parse(textBox1.Text) * 1000;
                timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Task connectTask = new Task(async (object state) =>
                {
                    clientPoint = new IPEndPoint(IPAddress.Parse("192.168.0.28"), 11000);
                    client = new TcpClient(clientPoint);
                    await client.ConnectAsync(serverEndPoint);
                    using (NetworkStream ns = client.GetStream())
                    {
                        byte[] buff = new byte[10240000];
                        var length = await ns.ReadAsync(buff);
                        using (MemoryStream ms = new MemoryStream(buff, 0, length))
                        {
                            var image = Image.FromStream(ms);

                            pictureBox1.BeginInvoke(() =>
                            {
                                pictureBox1.Image = image;
                            });
                            
                        }


                    }

                }, (client, serverEndPoint));
                connectTask.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScreenCaptureClient.ScreenCaptureServer form = new ScreenCaptureClient.ScreenCaptureServer();
            form.Show();
        }
    }
}