using System.Net;
using System.Net.Sockets;
using System.Text;

namespace NP_3_lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        Socket serverSocket;
        EndPoint remotePoint;
        private void button1_Click(object sender, EventArgs e)
        {
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            remotePoint = new IPEndPoint(IPAddress.Parse("192.168.0.28"), 11000);
            timer1.Interval = 1000;
            timer1.Start();


        }


        private async void button3_Click(object sender, EventArgs e)
        {
            clientForm form = new clientForm();
            form.Show();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            byte[]  buff = Encoding.Default.GetBytes(DateTime.Now.ToLongTimeString());
            await serverSocket.SendToAsync(buff, SocketFlags.None, remotePoint);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}