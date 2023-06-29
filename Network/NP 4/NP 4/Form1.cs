using System.Net;
using System.Net.Sockets;
using System.Text;

namespace NP_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Task task = null!;
        private void button1_Click(object sender, EventArgs e)
        {
            if(task == null)
            {
                task = Task.Run(async () =>
                {
                    IPAddress localAddress = IPAddress.Parse("192.168.0.28");
                    IPEndPoint localPoint = new IPEndPoint(localAddress, 11000);
                    TcpListener listener = new TcpListener(localPoint);
                    try
                    {
                        listener.Start(5);
                        do
                        {
                            if (listener.Pending())
                            {
                                TcpClient client = await listener.AcceptTcpClientAsync();
                                textBox1.BeginInvoke(() =>
                                {
                                    textBox1.Text += $"Client {client.Client.RemoteEndPoint} is connected";
                                });
                                byte[] buff = new byte[1024];
                                using (NetworkStream ns = client.GetStream())
                                {
                                    int len = await ns.ReadAsync(buff, 0, buff.Length);
                                    StringBuilder builder = new StringBuilder(textBox1.Text);
                                    builder.AppendLine($"{len} byte from client {client.Client.RemoteEndPoint}\r\n");
                                    builder.AppendLine($"Message: {Encoding.Default.GetString(buff, 0, len)}\r\n");
                                    textBox1.BeginInvoke(() =>
                                    {
                                        textBox1.Text = builder.ToString();
                                    });
                                }
                                client.Client.Shutdown(SocketShutdown.Both);
                                client.Close();
                            }
                        } while (true);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        listener.Stop();
                    }
                });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SimpleTcpClient form = new SimpleTcpClient();
            form.Show();
        }
    }
}