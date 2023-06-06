using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;


namespace AsyncUDPServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Task task = null;
        private void button1_Click(object sender, EventArgs e)
        {
            if (task == null)
            {
                task = Task.Run(async () =>
                {
                    Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP);
                    IPAddress serverAddress = IPAddress.Parse("192.168.0.28");
                    EndPoint endPoint = new IPEndPoint(serverAddress, 11000);
                    try
                    {

                        socket.Bind(endPoint);
                        do
                        {
                            EndPoint remoteEP = new IPEndPoint(IPAddress.Any, 11000);
                            byte[] buff = new byte[1024];
                            SocketReceiveFromResult res = await socket.ReceiveFromAsync(buff, SocketFlags.None, remoteEP);
                            textBox1.BeginInvoke(() =>
                            {
                                textBox1.Text += $"Message from {res.RemoteEndPoint}: {Encoding.Default.GetString(buff, 0, res.ReceivedBytes)}\r\n";

                            });

                        } 
                        while (true);
                    }
                    catch (Exception ex)
                    {
                        textBox1.BeginInvoke(() =>
                        {
                            textBox1.Text += ex.Message;
                        });
                    }
                });
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP);
            IPAddress startAddress = IPAddress.Parse("192.168.0.28");
            EndPoint endPoint = new IPEndPoint(startAddress, 11000);
            byte[] buff = Encoding.Default.GetBytes(textBox2.Text);
            await socket.SendToAsync(buff, SocketFlags.None, endPoint);
            socket.Shutdown(SocketShutdown.Send);
            socket?.Close();

        }
    }
}