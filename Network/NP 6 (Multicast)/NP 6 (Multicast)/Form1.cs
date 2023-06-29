using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

namespace NP_6__Multicast_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UdpClient? multicastClient = null;
        IPAddress? multicastIP = null;
        int multicastPort = 2024;
        IPAddress? localAddress;
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "224.5.5.24";
            textBox2.Text = $"{2024}";
            textBox4.Text = "John Snow";
            button2.Enabled = false;
            button3.Enabled = false;
            localAddress = GetLocalIP();
        }

        private async Task ListenAsync()
        {
            while (true)
            {
                if (multicastClient == null)
                    break;
                try
                {
                    UdpReceiveResult data = await multicastClient.ReceiveAsync();
                    string message = Encoding.Unicode.GetString(data.Buffer);
                    textBox3.BeginInvoke(() =>
                    {
                        textBox3.Text += message;
                        textBox3.SelectionStart = textBox3.TextLength;
                        textBox3.ScrollToCaret();
                    });

                }
                catch (Exception ex)
                {
                    textBox3.BeginInvoke(() =>
                    {
                        textBox3.Text += "Exception: " + ex.Message;
                    });
                }

            }
            return;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (multicastClient == null)
                return;
            if (string.IsNullOrEmpty(textBox5.Text))
                return;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine($"{textBox4.Text}");
            sb.AppendLine(textBox5.Text);
            sb.AppendLine();
            var data = Encoding.Unicode.GetBytes(sb.ToString());
            var remoteEP = new IPEndPoint(IPAddress.Parse(textBox1.Text), multicastPort);
            await multicastClient.SendAsync(data, remoteEP);
            textBox5.Text = "";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var hasError = false;
            StringBuilder sb = new StringBuilder();
            int tempMulticastPort;
            IPAddress parsedMulticastIP;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                sb.AppendLine("Please provide Multicast IP Address!");
                hasError = true;
            }
            if (!IPAddress.TryParse(textBox1.Text, out parsedMulticastIP!))
            {
                sb.AppendLine("Please provide Multicast IP Address!");
                hasError = true;
            }
            if (!int.TryParse(textBox2.Text, out tempMulticastPort))
            {
                sb.AppendLine("Please provide valid port number!");
                hasError = true;

            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                sb.AppendLine("Please provide user name!");
                hasError = true;
            }
            if (hasError)
            {
                MessageBox.Show(sb.ToString());
                return;
            }
            try
            {
                //multicastClient.Client.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.DropMembership, true);
                multicastClient?.DropMulticastGroup(multicastIP!);
                // 1:07:51

            }
            catch { }
            multicastPort = tempMulticastPort;
            multicastIP = parsedMulticastIP;
            multicastClient = new UdpClient();
            IPEndPoint localEP = new IPEndPoint(localAddress!, multicastPort);
            multicastClient!.JoinMulticastGroup(multicastIP!, localAddress);
            multicastClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            multicastClient.Client.Bind(localEP);
            multicastClient.MulticastLoopback = true;
            Task.Run(async () => await ListenAsync());
            sb = new StringBuilder();
            sb.AppendLine($"User {textBox4.Text} has joined the multicast group (chat)\r\n");
            var data = Encoding.Unicode.GetBytes(sb.ToString());
            await multicastClient.SendAsync(data, data.Length, new IPEndPoint(multicastIP!, multicastPort));
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
        }


        private async Task DisconnectAsync()
        {
            if (multicastClient == null) return;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"User {textBox4.Text} has left multicast group (chat)").AppendLine();
            var data = Encoding.Unicode.GetBytes(sb.ToString());
            await multicastClient.SendAsync(data, data.Length, new IPEndPoint(multicastIP!, multicastPort));
            multicastClient.DropMulticastGroup(multicastIP!);
            multicastClient.Close();
            multicastClient = null;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await DisconnectAsync();
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private IPAddress GetLocalIP()
        {
            string localIP;
            using(Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();
            }
            return IPAddress.Parse(localIP);
        }

        private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            await DisconnectAsync();
        }
    }
}