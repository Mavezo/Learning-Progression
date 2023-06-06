using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

namespace NP_2__lab_dz_1__server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Run(() => { ServerStart(); });
        }

        private async void ServerStart()
        {
            textBox1.BeginInvoke(() =>
            {
                StringBuilder sb = new StringBuilder(textBox1.Text);
                sb.AppendLine($"Server started {DateTime.Now}");
                textBox1.Text = sb.ToString();
            });
            try
            {

            IPAddress serverAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint endPoint = new IPEndPoint(serverAddress, 1024);
            Socket socket= new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            socket.Bind(endPoint);
            socket.Listen(20);
                while (true)
                {
                    Socket ns = await socket.AcceptAsync();
                    textBox1.BeginInvoke(() =>
                    {
                        StringBuilder stringBuilder = new StringBuilder(textBox1.Text);
                        stringBuilder.AppendLine($"Client with {ns.RemoteEndPoint} was connected ");
                        textBox1.Text = stringBuilder.ToString();
                    });

                    //Receive
                    byte[] buff = new byte[1024];
                    int lenght = 0;
                    StringBuilder sb = new StringBuilder();
                    do
                    {
                        lenght = await ns.ReceiveAsync(buff, SocketFlags.None);
                        sb.Append(Encoding.Default.GetString(buff)); 
                    }
                    while (lenght > 0);
                    textBox1.BeginInvoke(() =>{ textBox1.Text +=  sb.ToString(); });
                    //Send
                    buff = Encoding.Default.GetBytes($"Hello from server {ns.LocalEndPoint}: {DateTime.Now}");
                    await ns.SendAsync(buff, SocketFlags.None);




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            






        }






    }
}