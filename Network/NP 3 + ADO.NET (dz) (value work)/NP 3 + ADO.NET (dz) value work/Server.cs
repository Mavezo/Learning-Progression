using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NP_3___ADO.NET__dz__value_work.Models;
using System.Net;
using System.Net.Mime;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NP_3___ADO.NET__dz__value_work
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private async void Server_Load(object sender, EventArgs e)
        {
            using (HardwareDbContext context = new HardwareDbContext())
            {
                var hards = context.Hardwares.ToList();
                comboBox1.DataSource = null;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";
                comboBox1.DataSource = hards;
            }
        }
        Task task = null;
        IPAddress localIp;
        EndPoint localEndPoint;
        Socket serverSocket;
        private void button1_Click(object sender, EventArgs e)
        {
            if (task == null)
            {
                task = Task.Run(async () =>
                {
                    try
                    {

                        localIp = IPAddress.Parse("192.168.0.28");
                        localEndPoint = new IPEndPoint(localIp, 11000);
                        serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                        serverSocket.Bind(localEndPoint);
                        textBox1.BeginInvoke(() =>
                        {
                            textBox1.Text += $"Server with IP {serverSocket.LocalEndPoint} starts!\r\n";
                        });

                        EndPoint ep = new IPEndPoint(IPAddress.Any, 11001);
                        using (HardwareDbContext context = new HardwareDbContext())
                        {

                            while (true)
                            {
                                byte[] buff = new byte[1024];
                                var result = await serverSocket.ReceiveFromAsync(buff, SocketFlags.None, ep);
                                string text = Encoding.Default.GetString(buff, 0, result.ReceivedBytes);
                                Hardware currentHardware;
                                if (text == "Start")
                                {
                                    textBox1.BeginInvoke(() =>
                                    {
                                        textBox1.Text += $"Message from {result.RemoteEndPoint}: {text}\r\n";
                                    });
                                    buff = Encoding.Default.GetBytes(JsonConvert.SerializeObject(context.Hardwares.ToList()));
                                    await serverSocket.SendToAsync(buff, SocketFlags.None, result.RemoteEndPoint);

                                }
                                else if ((currentHardware = JsonConvert.DeserializeObject<Hardware>(text)!).GetType() == currentHardware.GetType())
                                {
                                    textBox1.BeginInvoke(() =>
                                    {
                                        textBox1.Text += $"Message from {result.RemoteEndPoint}: {currentHardware.Name}\r\n";
                                    });
                                    Prices price = context.Prices.Where(t => t.Hardware.Name == currentHardware.Name).FirstOrDefault()!;
                                    buff = Encoding.Default.GetBytes(JsonConvert.SerializeObject(price));
                                    await serverSocket.SendToAsync(buff, SocketFlags.None, result.RemoteEndPoint);


                                }
                            }
                        }
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




        private void button2_Click(object sender, EventArgs e)
        {
            Client form = new Client();
            form.Show();
        }
    }
}