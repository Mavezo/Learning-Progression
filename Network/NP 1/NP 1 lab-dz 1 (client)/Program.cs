using System.Net;
using System.Net.Sockets;
using System.Text;

//Develop two console applications using sockets. One application is a server, the other is a\
//client.The client application sends a greeting
//to the server. The server responds. Both the client and the server display
//the message received. Example output:
//Server:
//At 10:25 a.m., a line is received from [IP address]: Hello, Server!
//Client:
//At 10:26 a.m., a string is received from [IP address]: Hello, client!
//Use the synchronous socket mechanism.

IPAddress startIP = IPAddress.Parse("127.0.0.1");
IPEndPoint endPoint = new IPEndPoint(startIP, 1024);
Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
try
{
	clientSocket.Connect(endPoint);

	//Send
	byte[] buff = new byte[1024];
	string message1 = $"Message from {clientSocket.LocalEndPoint} ({DateTime.Now}): Hello, Server!";
	buff = Encoding.Default.GetBytes(message1);
	clientSocket.Send(buff);
	clientSocket.Shutdown(SocketShutdown.Send);


	//Receive
	buff = new byte[1024];
	int length = 0;
	StringBuilder sb = new StringBuilder();
	do
	{
		length = clientSocket.Receive(buff);
		string str = Encoding.Default.GetString(buff, 0, length);
		sb.Append(str);
	} while (clientSocket.Available > 0);
	Console.WriteLine(sb.ToString());


}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}
finally
{
	//clientSocket.Shutdown(SocketShutdown.Both);
	//clientSocket.Close();
}
