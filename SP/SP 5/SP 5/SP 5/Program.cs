using System.Diagnostics.Metrics;
using System.Threading;
using SP_5;

class Program
{
    static bool done;
    static readonly object locker = new object();
    static void Main(params string[] args)
    {
        Example1();
        Console.ReadKey();
        Console.ReadKey();
    }

    static void DoSomeWorkSynchronized2()
    {
        Monitor.Enter(locker);
        lock (locker)
        {
            if (!done)
            {
                done = true;
                Console.WriteLine($"Done in {Thread.CurrentThread.ManagedThreadId}");
            }
        }
    }

    static void DoSomeWorkSynchronized()
    {
        Monitor.Enter(locker);
        try
        {
            if (!done)
            {
                done = true;
                Console.WriteLine($"Done in {Thread.CurrentThread.ManagedThreadId}");
            }
        }
        finally { Monitor.Exit(locker); }
    }

    static void DoSomeWork()
    {
        if (!done)
        {
            done = true;
            Console.WriteLine($"Done in {Thread.CurrentThread.ManagedThreadId}");
        }
    }
    static void Example1()
    {
        Thread thread = new Thread(DoSomeWorkSynchronized);
        thread.Start();
        DoSomeWorkSynchronized();
        Console.ReadLine();


    }
    static void Example2()
    {
        Thread[] threads = new Thread[5];
        for (int i = 0; i < threads.Length; i++)
        {
            Thread thread = new Thread(() =>
            {
                for (int j = 0; j < 10000000; j++)
                {
                    Interlocked.Increment(ref Counter.Count);
                    //++Counter.Count;
                }
            });
            threads[i] = thread;
            thread.Start();
        }
        for (int i = 0; i < threads.Length; i++)
        {
            threads[i].Join();
        }
        Console.WriteLine($"Counter: {Counter.Count}");
        Program program = new Program();
        program.GetType();
        Console.ReadKey();
    }
    static void Example3()
    {
        Thread[] threads = new Thread[5];
        for (int i = 0; i < threads.Length; i++)
        {
            Thread thread = new Thread(() =>
            {
                for (int j = 0; j < 1000000; j++)
                {
                    Monitor.Enter(locker);
                    try
                    {
                        ++Counter.Count;
                    }
                    finally { Monitor.Exit(locker); }
                }
                //Interlocked.Increment(ref Counter.Count);
            });
            threads[i] = thread;
            thread.Start();
        }
        for (int i = 0; i < threads.Length; i++)
        {
            threads[i].Join();
        }
        Console.WriteLine($"Counter: {Counter.Count}");
        Program program = new Program();
        program.GetType();
        Console.ReadKey();
    }

}
