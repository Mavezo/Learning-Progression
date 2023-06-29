using ScreenSaver;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net;
using System.Net.Sockets;


IPEndPoint localPoint = new IPEndPoint(IPAddress.Parse("192.168.0.28"), 11001);
TcpListener listener = new TcpListener(localPoint);
try
{
    listener.Start();
    Console.WriteLine("Server starts!");
    do
    {
        if (listener.Pending())
        {
            TcpClient client = await listener.AcceptTcpClientAsync();
            Console.WriteLine("Connected!");
            byte[] buff = new byte[8192];
            using(NetworkStream ns = client.GetStream())
            {
                ScreenCapture capture = new ScreenCapture();
                Console.WriteLine("Captured!");
                Image image = capture.CaptureScreen();
                using (var memoryStream = new MemoryStream())
                {
                    image.Save(memoryStream, ImageFormat.Bmp);
                    buff = memoryStream.ToArray();
                }
                await ns.WriteAsync(buff, 0, buff.Length);
                Console.WriteLine("Sent!");


            }


        }


    } while (true);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}



