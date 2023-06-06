using Newtonsoft.Json;
using NP_3___ADO.NET__dz__value_work.Models;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_3___ADO.NET__dz__value_work
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        Socket clientSocket;
        EndPoint serverEndPoint;
        EndPoint clientEndPoint;
        byte[] buff;
        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {

                IPAddress serverIP = IPAddress.Parse("192.168.0.28");
                serverEndPoint = new IPEndPoint(serverIP, 11000);

                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                clientSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                buff = new byte[1024];

                IPAddress clientIP = IPAddress.Parse("192.168.0.28");
                bool isPortFree = false;
                Random rand = new Random();
                while (!isPortFree)
                {
                    try
                    {
                        clientEndPoint = new IPEndPoint(clientIP, rand.Next(11001, 65000));
                        clientSocket.Bind(clientEndPoint);
                        isPortFree= true;
                    }
                    catch (Exception)
                    {
                        isPortFree = false;
                    }
                }

                textBox2.BeginInvoke(() =>
                {
                    textBox2.Text = clientEndPoint.ToString();
                });
   
                textBox3.BeginInvoke(() =>
                {
                    textBox3.Text = serverEndPoint.ToString();
                });


                buff = Encoding.Default.GetBytes("Start");
                await clientSocket.SendToAsync(Encoding.Default.GetBytes("Start"), SocketFlags.None, serverEndPoint);

                buff = new byte[1024];
                var result = await clientSocket.ReceiveFromAsync(buff, SocketFlags.None, clientEndPoint);


                List<Hardware> list = JsonConvert.DeserializeObject<List<Hardware>>(Encoding.Default.GetString(buff, 0, result.ReceivedBytes))!;
                listBox1.DisplayMember = "Name";
                listBox1.ValueMember = "Id";
                listBox1.DataSource = list;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (listBox1.SelectedItems.Count > 0)
                {
                    buff = new byte[1024];
                    buff = Encoding.Default.GetBytes(JsonConvert.SerializeObject(listBox1.SelectedItem as Hardware));
                    await clientSocket.SendToAsync(buff, SocketFlags.None, serverEndPoint);
                    buff = new byte[1024];

                    var result = await clientSocket.ReceiveFromAsync(buff, SocketFlags.None, clientEndPoint);
                    Prices price = JsonConvert.DeserializeObject<Prices>(Encoding.Default.GetString(buff, 0, result.ReceivedBytes))!;

                    textBox1.BeginInvoke(() =>
                    {
                        textBox1.Text = price.Price.ToString();
                    });


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
