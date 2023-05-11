using System.Numerics;


ParameterizedThreadStart firstThreadStart = new ParameterizedThreadStart((object obj) =>
{
    lock (obj)
    {
        List<int> list = (List<int>)obj;
        list.Sort();
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
});

ParameterizedThreadStart secondThreadStart = new ParameterizedThreadStart((object obj) =>
{
    (List<int>, int) tuple = ((List<int>, int))(obj);
    lock (tuple.Item1)
    {
        if (tuple.Item1.Contains(tuple.Item2))
        {
            Console.WriteLine($"List contains {tuple.Item2}");
        }
        else
        {
            Console.WriteLine($"List don't contains {tuple.Item2}");
        }
    }
});



List<int> list = new List<int>();

Random rand = new Random();
for(int i = 0; i < 100; i++)
{
    list.Add(rand.Next(0, 101));
}

Thread firstThread = new Thread(firstThreadStart);  
firstThread.Start(list);

Thread secondThread = new Thread(secondThreadStart);
secondThread.Start((list, 10));

