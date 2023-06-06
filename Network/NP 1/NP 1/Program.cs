using System.Net;
using System.Net.Sockets;
using System.Text;

static void ClientExample()
{
    IPAddress iPAddress = IPAddress.Parse("216.58.209.14");
    IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, 80);
    Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
    try
    {
        socket.Connect(iPEndPoint);
        string message = "GET \r\n\r\n";
        byte[] buff = Encoding.Default.GetBytes(message);
        socket.Send(buff);
        int length = 0;
        buff = new byte[1024];
        StringBuilder builder = new StringBuilder();
        do
        {
            length = socket.Receive(buff);
            string str = Encoding.Default.GetString(buff, 0, length);
            builder.Append(str);
        }
        while (length > 0);
        Console.WriteLine(builder.ToString());

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        socket.Shutdown(SocketShutdown.Both);
        socket.Close();
    }
}


IPAddress firstAddress = IPAddress.Parse("127.0.0.1");
IPEndPoint serwerPoint = new IPEndPoint(firstAddress, 1024);
Socket listeningSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
listeningSocket.Bind(serwerPoint);
listeningSocket.Listen();
while (true)
{
    Socket clientSocket = listeningSocket.Accept();
    Console.WriteLine($"Socket with endpoint {clientSocket.RemoteEndPoint} connected");
    Console.WriteLine($"New server socket with endpoint {clientSocket.LocalEndPoint} was created");
    string message = $"Responce from {clientSocket.LocalEndPoint}: Current time is {DateTime.Now.ToLongTimeString()}";
    byte[] buff = Encoding.Default.GetBytes(message);
    clientSocket.Send(buff);
    clientSocket.Shutdown(SocketShutdown.Both);
    clientSocket.Close();   
}

