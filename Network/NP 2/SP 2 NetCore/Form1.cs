using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SP_2_NetCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Run(ServerFunc);
        }


        delegate void TextDelegate(string text);

        private async void ServerFunc()
        {
            this.BeginInvoke(new TextDelegate(UpdateTextBox), $"Server Task started!");
            IPAddress startIP = IPAddress.Parse("127.0.0.1");
            IPEndPoint endPoint = new IPEndPoint(startIP, 1025);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            socket.Bind(endPoint);
            socket.Listen(20);
            try
            {
                while (true)
                {
                    Socket ns = await socket.AcceptAsync();
                    textBox1.BeginInvoke(new TextDelegate(UpdateTextBox), $"Client with {ns.RemoteEndPoint} was connected! Thread {Thread.CurrentThread.ManagedThreadId}");
                    byte[] buff = Encoding.Default.GetBytes($"Message from {ns.LocalEndPoint}: {DateTime.Now.ToLongTimeString()}");
                    int lenght = await ns.SendAsync(new ArraySegment<byte>(buff), SocketFlags.None);
                    textBox1.BeginInvoke(new TextDelegate(UpdateTextBox), $"{lenght} bytes was sent to {ns.RemoteEndPoint}");
                    ns.Shutdown(SocketShutdown.Both);



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateTextBox(string text)
        {
            StringBuilder builder = new StringBuilder(textBox1.Text);
            builder.AppendLine(text);
            textBox1.Text = builder.ToString(); 

        }


        
    }
}