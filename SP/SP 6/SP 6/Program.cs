using System.Threading;
using System.Threading.Tasks.Dataflow;

static void Example1 (object? obj)
{
    (int, AutoResetEvent) tuple = ((int, AutoResetEvent))(obj);
    if (tuple.Item2!.WaitOne())
    {
        Console.WriteLine($"Thread {tuple.Item1}) {Thread.CurrentThread.ManagedThreadId} obtain control and continue to work");
        tuple.Item2.Set();
    }
    else
    {
        Console.WriteLine($"Thread {tuple.Item1}) {Thread.CurrentThread.ManagedThreadId} didn't obtain control and stop working");
    }
}

AutoResetEvent resetEvent= new AutoResetEvent(true);
for (int i = 0; i < 10; i++)
{
    ThreadPool.QueueUserWorkItem(Example1, (i, resetEvent));
    Thread.Sleep(1000);
}
Console.ReadLine();

