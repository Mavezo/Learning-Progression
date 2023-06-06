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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NP_3_lab_1
{
    public partial class clientForm : Form
    {
        public clientForm()
        {
            InitializeComponent();
        }

        private async void clientForm_Load(object sender, EventArgs e)
        {

            await Task.Run(async () =>
            {
                try
                {
                    Random rand = new Random();
                    int port = rand.Next(11000, 11050);
                    IPAddress address = IPAddress.Parse("192.168.0.28");
                    EndPoint endPoint = new IPEndPoint(address, 11000);
                    Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    socket.Bind(endPoint);
                    byte[] buff = new byte[1024];
                    do
                    {

                        EndPoint ep = new IPEndPoint(IPAddress.Any, port);
                        SocketReceiveFromResult res = await socket.ReceiveFromAsync(buff, SocketFlags.None, ep);
                        textBox1.BeginInvoke(() =>
                        {
                            textBox1.Text = $"{Encoding.Default.GetString(buff, 0, res.ReceivedBytes)}";
                        });
                    }
                    while (true);




                }
                catch { }

            });
        }

        private void clientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
   
        }
    }
}