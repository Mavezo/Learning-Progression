using System.Net;
using System.Net.Sockets;
using System.Text;

namespace NP_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread thread = null;

        public delegate void TextDelegate(string text);

        private void button1_Click(object sender, EventArgs e)
        {
            if(thread == null) {
                thread = new Thread(ReceiveFunc);
                thread.IsBackground = true;
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP);
                IPAddress startAddress = IPAddress.Parse("192.168.0.28");
                IPEndPoint endPoint = new IPEndPoint(startAddress, 11000);
                socket.Bind(endPoint);
                thread.Start(socket);
            }


        }

        private void ReceiveFunc(object? obj)
        {
            try
            {
                Socket? receiveSocket = obj as Socket;
                EndPoint endPoint = new IPEndPoint(IPAddress.Any, 11000 );
                byte[] buff = new byte[1024];
                do
                {
                    int lenght = receiveSocket!.ReceiveFrom(buff, ref endPoint);
                    string text = Encoding.Default.GetString(buff, 0, lenght);
                    textBox1.BeginInvoke(new TextDelegate(UpdateTextBox), $"Message from {endPoint}: ");
                    textBox1.BeginInvoke(new TextDelegate(UpdateTextBox), $"{text} \r\n");
                } while (true);

            }
            catch (Exception ex)
            {
                textBox1.BeginInvoke(new TextDelegate(UpdateTextBox), ex.Message);
            }
            //47:49
            //47:49
            //47:49
            //47:49
            //47:49
            //47:49
            //47:49
            //47:49

        }

        private void UpdateTextBox(string text)
        {
            StringBuilder sb = new StringBuilder(textBox1.Text);
            sb.Append(text);
            textBox1.Text = sb.ToString();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Socket senderSocket = new Socket(AddressFamily.InterNetwork,SocketType.Dgram, ProtocolType.IP);
            IPAddress ipAddress = IPAddress.Parse("192.168.0.255");
            IPEndPoint endPoint = new IPEndPoint(ipAddress, 11000);
            byte[] buff = Encoding.Default.GetBytes(textBox2.Text);
            senderSocket.SendTo(buff, endPoint);
            senderSocket.Shutdown(SocketShutdown.Both);
            senderSocket?.Close();

        }
    }
}