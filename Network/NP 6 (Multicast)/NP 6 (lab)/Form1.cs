using System.Net.Sockets;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Diagnostics;

namespace NP_6__lab_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UdpClient? multicastClient;
        Dictionary<string, IPAddress> chats = new Dictionary<string, IPAddress>();
        IPEndPoint? localEP = null;
        private async void Form1_Load(object sender, EventArgs e)
        {
            chats.Add("Local", IPAddress.Parse("224.0.0.24"));
            chats.Add("Trade", IPAddress.Parse("224.2.2.2"));
            chats.Add("Global",  IPAddress.Parse("224.3.3.3"));
            try
            {
                multicastClient?.DropMulticastGroup(chats["Local"]);
                //multicastClient?.DropMulticastGroup(chats["Trade"]);
                //multicastClient?.DropMulticastGroup(chats["Global"]);
            } catch{}
            try
            {
                localEP = new IPEndPoint(GetLocalIPv4(), 2024);
                multicastClient = new UdpClient();
                multicastClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);   
                multicastClient.JoinMulticastGroup(chats["Local"], localEP.Address);
                multicastClient.JoinMulticastGroup(chats["Trade"], localEP.Address);
                multicastClient.JoinMulticastGroup(chats["Global"], localEP.Address);
                multicastClient.Client.Bind(localEP);
                multicastClient.MulticastLoopback = true;
                Task.Run(async () => await ListenAsync());
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Main client started!");
                var data = Encoding.Unicode.GetBytes(sb.ToString());
                await multicastClient.SendAsync(data, data.Length, new IPEndPoint(chats["Local"], 2024));
                await multicastClient.SendAsync(data, data.Length, new IPEndPoint(chats["Trade"], 2024));
                await multicastClient.SendAsync(data, data.Length, new IPEndPoint(chats["Global"], 2024));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async Task ListenAsync()
        {
            while (true)
            {
                if (multicastClient == null) break;
                try
                {

                    UdpReceiveResult res = await multicastClient.ReceiveAsync();
                    string message = Encoding.Unicode.GetString(res.Buffer);
                    MessageBox.Show(message);




                    //if (message[0] == '~')
                    //{
                    //    local_TextBox.BeginInvoke(() =>
                    //    {
                    //        local_TextBox.Text += message;
                    //        local_TextBox.SelectionStart = local_TextBox.TextLength;
                    //        local_TextBox.ScrollToCaret();
                    //    });
                    //}
                    //if (message[1] == '$')
                    //{
                    //    trade_TextBox.BeginInvoke(() =>
                    //    {
                    //        trade_TextBox.Text += message;
                    //        trade_TextBox.SelectionStart = trade_TextBox.TextLength;
                    //        trade_TextBox.ScrollToCaret();
                    //    });
                    //}
                    //if (message[2] == '!')
                    //{
                    //    global_TextBox.BeginInvoke(() =>
                    //    {
                    //        global_TextBox.Text += message;
                    //        global_TextBox.SelectionStart = global_TextBox.TextLength;
                    //        global_TextBox.ScrollToCaret();
                    //    });
                    //}

                    if (res.RemoteEndPoint == new IPEndPoint(chats["Local"], 2024))
                    {
                        local_TextBox.BeginInvoke(() =>
                        {
                            local_TextBox.Text += message;
                            local_TextBox.SelectionStart = local_TextBox.TextLength;
                            local_TextBox.ScrollToCaret();
                        });
                    }
                    if (res.RemoteEndPoint == new IPEndPoint(chats["Trade"], 2024)) 
                    {
                        trade_TextBox.BeginInvoke(() =>
                        {
                            trade_TextBox.Text += message;
                            trade_TextBox.SelectionStart = trade_TextBox.TextLength;
                            trade_TextBox.ScrollToCaret();
                        });
                    }
                     if (res.RemoteEndPoint == new IPEndPoint(chats["Global"], 2024))
                    {
                        global_TextBox.BeginInvoke(() =>
                        {
                            global_TextBox.Text += message;
                            global_TextBox.SelectionStart = global_TextBox.TextLength;
                            global_TextBox.ScrollToCaret();
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if(multicastClient == null) 
            {
                return;
            }
            if(string.IsNullOrEmpty(message_TextBox.Text))
            {
                return;
            }

            var data = Encoding.Unicode.GetBytes(message_TextBox.Text);
            if (Local_CheckBox.Checked)
            {
                await multicastClient.SendAsync(data, data.Length, new IPEndPoint(chats["Local"], 2024));
                MessageBox.Show(chats["Local"].ToString());
            }
            if (Trade_CheckBox.Checked)
            {
                await multicastClient.SendAsync(data, data.Length, new IPEndPoint(chats["Trade"], 2024));
            }
            if (Global_CheckBox.Checked)
            {
                await multicastClient.SendAsync(data, data.Length, new IPEndPoint(chats["Global"], 2024));
            }
        }

        private IPAddress GetLocalIPv4()
        {
            TcpClient tcpClient = new TcpClient();
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("8.8.8.8"), 53);
            tcpClient.Connect(remoteIP);
            IPAddress address = (tcpClient.Client.LocalEndPoint as IPEndPoint)!.Address;
            tcpClient.Close();
            return address.MapToIPv4();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                multicastClient?.DropMulticastGroup(chats["Local"], 2);
                multicastClient?.DropMulticastGroup(chats["Trade"], 2);
                multicastClient?.DropMulticastGroup(chats["Global"], 2);
            }
            catch { }
        }
    }
}