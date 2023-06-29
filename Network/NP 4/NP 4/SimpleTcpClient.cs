using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_4
{
    public partial class SimpleTcpClient : Form
    {
        public SimpleTcpClient()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            TcpClient client = null;
            try
            {
                client = new TcpClient(new IPEndPoint(IPAddress.Parse("192.168.0.28"), 11010));
                IPEndPoint serverPoint = new IPEndPoint(IPAddress.Parse("192.168.0.28"), 11001);
                await client.ConnectAsync(serverPoint);
                textBox2.Text = client.Client.LocalEndPoint!.ToString();
                textBox3.Text = serverPoint.ToString();
                textBox1.Text += $"Connected to server {serverPoint}!\r\n";
                byte[] buff = new byte[1024];
                buff = Encoding.Default.GetBytes("Hello from client!\r\n");
                using (NetworkStream ns = client.GetStream())
                {
                    await ns.WriteAsync(buff, 0, buff.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                client.Client.Close();
                client?.Close();
            }
        }
    }
}
