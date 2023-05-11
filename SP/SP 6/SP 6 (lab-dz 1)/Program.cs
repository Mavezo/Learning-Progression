List<int> list = new List<int>();
AutoResetEvent resetEvent= new AutoResetEvent(true);

ParameterizedThreadStart firstThreadStart = new ParameterizedThreadStart((object obj) =>
{
    (List<int>, AutoResetEvent) tuple = ((List<int>, AutoResetEvent))(obj);
    if (tuple.Item2.WaitOne(10))
    {
        Console.WriteLine("Additing to the list");
        Random rand = new Random();
        for (int i = 0; i < 1000; i++)
        {
            tuple.Item1.Add(rand.Next(0, 5001));
        }
        tuple.Item2.Set();
    }
    else
    {
        Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}) Wait (first)");
    }
});

Thread firstThread = new Thread(firstThreadStart);
firstThread.Start((list, resetEvent));
Thread.Sleep(1000);

ParameterizedThreadStart secondThreadStart = new ParameterizedThreadStart((object obj) =>
{
    (List<int>, AutoResetEvent) tuple = ((List<int>, AutoResetEvent))(obj);
    if (tuple.Item2.WaitOne())
    {
        Console.WriteLine($"Max from list: {list.Max()}");
        tuple.Item2.Set();

    }
    else
    {
        Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}) Wait (second)");
    }
});

Thread secondThread = new Thread(secondThreadStart);
secondThread.Start((list, resetEvent));
Thread.Sleep(1000);


ParameterizedThreadStart thirdThreadStart = new ParameterizedThreadStart((object obj) =>
{
    (List<int>, AutoResetEvent) tuple = ((List<int>, AutoResetEvent))(obj);
    if (tuple.Item2.WaitOne())
    {
        Console.WriteLine($"Min from list: {list.Min()}");
        tuple.Item2.Set();

    }
    else
    {
        Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}) Wait (third)");
        tuple.Item2.Set();
    }
});

Thread thirdThread = new Thread(thirdThreadStart);    
thirdThread.Start((list, resetEvent));
Thread.Sleep(1000);


ParameterizedThreadStart fourthThreadStart = new ParameterizedThreadStart((object obj) =>
{
    (List<int>, AutoResetEvent) tuple = ((List<int>, AutoResetEvent))(obj);
    if (tuple.Item2.WaitOne())
    {
        Console.WriteLine($"Avg from list: {list.Average()}");
    }
    else
    {
        Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}) Wait (fourth)");
        tuple.Item2.Set();
    }
});

Thread fourthThread = new Thread(fourthThreadStart);
fourthThread.Start((list, resetEvent));