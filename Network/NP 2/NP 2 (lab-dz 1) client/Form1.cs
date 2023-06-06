using System.Net;
using System.Net.Sockets;
using System.Text;

namespace NP_2__lab_dz_1__client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                IPAddress ip = IPAddress.Parse("127.0.0.1");
                IPEndPoint endPoint = new IPEndPoint(ip, 1024);
                Socket startSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                try
                {
                    //Send
                    await startSocket.ConnectAsync(endPoint);
                    string message = $"Hello from client {DateTime.Now.ToString()}: {startSocket.LocalEndPoint} ";
                    byte[] buff = new byte[1024];
                    buff = Encoding.Default.GetBytes(message);
                    await startSocket.SendAsync(buff, SocketFlags.None);
                    startSocket.Shutdown(SocketShutdown.Send);

                    //Receive
                    int lenght = 0;
                    StringBuilder sb = new StringBuilder();
                    do
                    {
                        lenght = await startSocket.ReceiveAsync(buff, SocketFlags.None);
                        sb.Append(Encoding.Default.GetString(buff, 0, lenght));
                    } while(startSocket.Available > 0);
                    textBox1.BeginInvoke(() =>
                    {
                        textBox1.Text +=  sb.ToString();
                    });


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
}