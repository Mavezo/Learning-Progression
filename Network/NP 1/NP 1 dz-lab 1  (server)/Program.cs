using System.Net;
using System.Net.Sockets;
using System.Text;


//Develop two console applications using sockets. One application is a server, the other is a
//client.The client application sends a greeting
//to the server. The server responds. Both the client and the server display
//the message received. Example output:
//Server:
//At 10:25 a.m., a line is received from [IP address]: Hello, Server!
//Client:
//At 10:26 a.m., a string is received from [IP address]: Hello, client!
//Use the synchronous socket mechanism.



try
{
    IPAddress serverAddres = IPAddress.Parse("127.0.0.1");
    IPEndPoint serverEndPoint = new IPEndPoint(serverAddres, 1024);
    Socket startSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
    startSocket.Bind(serverEndPoint);
    startSocket.Listen();
    while (true)
    {
        Socket acceptSocket = startSocket.Accept();
        Console.WriteLine($"Socket with EndPoint {acceptSocket.RemoteEndPoint} connected");
        Console.WriteLine($"New server socket with EndPoint {acceptSocket.LocalEndPoint} was created");

        //Receive


        byte[] buff = new byte[1024];
        StringBuilder sb = new StringBuilder();
        int length = 0;
        do
        {
            length = acceptSocket.Receive(buff);
            string str = Encoding.Default.GetString(buff, 0, length);
            sb.Append(str);
        } while (length > 0);
        Console.WriteLine(sb.ToString());

        buff = new byte[1024];
        //Send
        string message1 = $"Message from {acceptSocket.LocalEndPoint} ({DateTime.Now.ToLongTimeString()}): Hello, Client!";
        buff = Encoding.Default.GetBytes(message1);
        acceptSocket.Send(buff);




        //acceptSocket.Shutdown(SocketShutdown.Both);
        //acceptSocket.Close();

    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);

}