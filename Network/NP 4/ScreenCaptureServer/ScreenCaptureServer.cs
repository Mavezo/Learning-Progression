using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScreenSaver;
using System.Drawing.Imaging;

namespace ScreenCaptureClient
{
    public partial class ScreenCaptureServer : Form
    {
        public ScreenCaptureServer()
        {
            InitializeComponent();
        }

        Task task = null;
        IPEndPoint localPoint;
        TcpListener listener;
        private async void button1_Click(object sender, EventArgs e)
        {
            if (task == null)
            {
                task = Task.Run(async () =>
                {
                    localPoint = new IPEndPoint(IPAddress.Parse("192.168.0.28"), 11001);
                    listener = new TcpListener(localPoint);
                    try
                    {
                        listener.Start();
                        textBox1.BeginInvoke(() => { textBox1.Text += "Server starts!"; });
                        do
                        {
                            if (listener.Pending())
                            {
                                TcpClient client = await listener.AcceptTcpClientAsync();
                                textBox1.BeginInvoke(() => { textBox1.Text += "Connected!"; });
                                byte[] buff = new byte[8192];
                                using (NetworkStream ns = client.GetStream())
                                {
                                    ScreenCapture capture = new ScreenCapture();
                                    textBox1.BeginInvoke(() => { textBox1.Text += "Captured!"; });
                                    Image image = capture.CaptureScreen();
                                    var memoryStream = new MemoryStream();

                                    image.Save(memoryStream, ImageFormat.Bmp);
                                    buff = memoryStream.ToArray();

                                    await ns.WriteAsync(buff, 0, buff.Length);
                                    textBox1.BeginInvoke(() => { textBox1.Text += "Sent!"; });

                                }


                            }


                        } while (true);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                });
            }

        }
    }
}
