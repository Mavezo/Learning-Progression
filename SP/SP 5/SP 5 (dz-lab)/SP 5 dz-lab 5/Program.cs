using System.Threading;

Thread[] threads = new Thread[10];
Semaphore semaphore = new Semaphore(3, 3);
ThreadStart threadStart = new ThreadStart(() =>
{
    semaphore.WaitOne();
    Console.WriteLine($"Thread with ID {Thread.CurrentThread.ManagedThreadId} started");
    Random rand = new Random();
    Console.WriteLine($"Random numbers: {rand.Next(100, 999)}");
    Console.WriteLine($"Thread with ID {Thread.CurrentThread.ManagedThreadId} ended");
    semaphore.Release();
});
for(int i = 0; i < threads.Length; i++)
{
    threads[i] = new Thread(threadStart);
    threads[i].Start();
}




