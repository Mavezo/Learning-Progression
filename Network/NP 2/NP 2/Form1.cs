using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.CompilerServices;

namespace NP_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread thread;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if(thread == null)
            {

                thread = new Thread(ServerFunc);
                thread.IsBackground = true;
                thread.Start();
                textBox1.Text = "Server is working!";
            }
        }

        private void ServerFunc()
        {
            IPAddress serverAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint serverEndPoint = new IPEndPoint(serverAddress, 1024);
            Socket startSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            startSocket.Bind(serverEndPoint);
            startSocket.Listen(20);
            try
            {
                IAsyncResult ar = startSocket.BeginAccept(AcceptCallBck, startSocket);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void AcceptCallBck(IAsyncResult ar)
        {
            Socket socket = ar.AsyncState as Socket;
            Socket acceptSocket = socket.EndAccept(ar);
            textBox1.BeginInvoke(new TextDelegate(UpdateTextBox), $"Client with {acceptSocket.RemoteEndPoint} was connected!");
            byte[] buff = new byte[1024];
            buff = Encoding.Default.GetBytes($"Message from {acceptSocket.LocalEndPoint}: {DateTime.Now.ToShortTimeString()}");

            acceptSocket.BeginSend(buff, 0, buff.Length, SocketFlags.None,  SendCallBackFnc, acceptSocket);
            socket.BeginAccept(AcceptCallBck, socket);
        }



        private void SendCallBackFnc(IAsyncResult ar)
        {
            Socket ns = ar.AsyncState as Socket;
            int lenght = ns.EndSend(ar);
            textBox1.BeginInvoke(new TextDelegate(UpdateTextBox), $"{lenght} bytes was sent to {ns.RemoteEndPoint}");
            ns.Shutdown(SocketShutdown.Both);
            ns.Close();

        }



        public delegate void TextDelegate(string text);
        private void UpdateTextBox (string str)
        {
            StringBuilder sb = new StringBuilder(textBox1.Text);
            sb.AppendLine(str);
            textBox1.Text = sb.ToString(); 

        }

    }
}
