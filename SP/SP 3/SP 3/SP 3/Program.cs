using System.Threading;

Console.WriteLine("Hello, World!");

ParameterizedThreadStart threadStart = (object? end) =>
{
    int temp = Convert.ToInt32(end);
    for (int i = 0; i < temp; i++)
    {
        Console.WriteLine($"\t\t\tFrom additional thread: {i}");
    }



};

Thread thread = new Thread(threadStart);
thread.Start(20);


//thread.Join();  
//thread.IsBackground = true; 
Console.WriteLine($"Message from base thread with Id: {Thread.CurrentThread.ManagedThreadId}, Priority: {Thread.CurrentThread.Priority}");

