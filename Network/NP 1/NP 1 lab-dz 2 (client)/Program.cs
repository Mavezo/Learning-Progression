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

IPAddress clientIP = IPAddress.Parse("127.0.0.1");
IPEndPoint clientEndPoint = new IPEndPoint(clientIP, 1024);

Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream,ProtocolType.IP);
try
{

    clientSocket.Connect(clientEndPoint);
    Console.WriteLine($"Connected! Available command: \r\nDate\r\nTime");

    // Send
    string answer = Console.ReadLine();
    byte[] buff = new byte[1024];
    buff = Encoding.Default.GetBytes(answer);
    clientSocket.Send(buff);
    clientSocket.Shutdown(SocketShutdown.Send);


    //Receive
    buff = new byte[1024];
    int lenght = 0;
    do
    {
        lenght = clientSocket.Receive(buff);
        Console.Write(Encoding.Default.GetString(buff));
    } while(clientSocket.Available > 0);
    





}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    clientSocket.Shutdown(SocketShutdown.Both);
    clientSocket.Close();

}





Console.ReadLine();