using System.Threading;
using System.Transactions;

int minWorkerThreadCount, minCompletionPortCount;
ThreadPool.GetMinThreads(out minWorkerThreadCount,out minCompletionPortCount);
Console.WriteLine($"Min count of worker threads: {minWorkerThreadCount}, max count of I/O threads {minCompletionPortCount}");



int maxWorkerThreadCount, maxCompletionPortCount;
ThreadPool.GetMaxThreads(out maxWorkerThreadCount, out maxCompletionPortCount);
Console.WriteLine($"Max count of worker threads: {maxWorkerThreadCount}, max count of I/O threads {maxCompletionPortCount}");

int availableWorkerThreadCount, availableCompletionPortCount;
ThreadPool.GetAvailableThreads(out availableWorkerThreadCount, out availableCompletionPortCount);
Console.WriteLine($"Count of available worker threads {availableWorkerThreadCount}, count of available I/O threads {availableCompletionPortCount} ");


static void WorkingMethod(object? state)
{
    int? num = state as int?;
    Console.WriteLine($"Thread with ID {Thread.CurrentThread.ManagedThreadId} state: {num}");
    Thread.Sleep(5000);
}

ThreadPool.QueueUserWorkItem(WorkingMethod, 15);
ThreadPool.GetAvailableThreads(out availableWorkerThreadCount, out availableCompletionPortCount);
Console.WriteLine($"Count of available worker threads {availableWorkerThreadCount}, count of available I/O threads {availableCompletionPortCount} ");

Thread.Sleep(1000);
Console.WriteLine("Main thread was ended");

