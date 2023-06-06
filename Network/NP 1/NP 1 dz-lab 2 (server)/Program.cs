//Develop a set of console applications. The first
//application: a server application that returns the current time or
//The first application: a server application that returns the current time or date on the server.
//The second application: a client application that requests the date or time. The user uses the keyboard
//determines what to ask for. After sending the date
//or time, the server breaks the connection. The client
//application displays the received data.
//Use the synchronous socket mechanism.

using System.Net;
using System.Net.Sockets;
using System.Text;

IPAddress serverIP = IPAddress.Parse("127.0.0.1");
IPEndPoint serverEndPoint = new IPEndPoint(serverIP, 1024);
Socket startSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream,ProtocolType.IP);
startSocket.Bind(serverEndPoint);
startSocket.Listen();
while (true)
{
        Socket acceptSocket = startSocket.Accept();
        Console.WriteLine($"Socket with EndPoint {acceptSocket.RemoteEndPoint} connected");
        Console.WriteLine($"New server socket with EndPoint {acceptSocket.LocalEndPoint} was created");
    try
    {
        byte[] buff = new byte[1024];
        int lenght = 0;
        StringBuilder sb = new StringBuilder();
        do
        {
            lenght = acceptSocket.Receive(buff);
            sb.Append(Encoding.Default.GetString(buff, 0, lenght));
        } while (lenght > 0);
        Console.WriteLine(sb.ToString());

        string message = string.Empty;
        switch (sb.ToString().ToLower())
        {
            case "date":
                {
                    message = $"Current date: {DateTime.Now.ToShortDateString()}";
                    break;
                }
            case "time":
                {
                    message = $"Current time: {DateTime.Now.ToShortTimeString()}";
                    break;
                }
            default:
                {
                    message = $"Wrong query!";
                    break;
                }
        }
        buff = new byte[1024];
        buff = Encoding.Default.GetBytes(message);
        acceptSocket.Send(buff);
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        acceptSocket.Shutdown(SocketShutdown.Both);
        acceptSocket.Close();
    }

}

