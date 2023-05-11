
//Console.WriteLine("Enter threads count:");
//int count = Convert.ToInt32(Console.ReadLine());

//ParameterizedThreadStart threadStart = ((object obj) =>
//{
//	Console.WriteLine();
//	(int, int) var = ((int, int))obj;
//	for (int i = var.Item1; i <= var.Item2; i++)
//	{
//		Console.Write(i);
//	}
//	Console.WriteLine();
//});
//for (int i = 0; i < count; i++)
//{
//    Thread thread = new Thread(threadStart);
//	thread.Start((1, 5));
//}


List<int> list= new List<int>();
Random rand = new Random();

StreamWriter sw = new StreamWriter("text1.txt");


    for (int i = 0; i < 100000000; i++)
    {
            list.Add(rand.Next(1,100));
           // sw.Write($"{list[i]}, ");
    }

    ParameterizedThreadStart max = new ParameterizedThreadStart( (object obj) =>
    {
        var list = obj as List<int>;
        string str = $"Max number in list = {list.Max()}";
        Console.WriteLine(str);
    //     sw.WriteLine(str);
    });
    ParameterizedThreadStart min = new ParameterizedThreadStart( (object obj) =>
    {
        var list = obj as List<int>;
        string str = $"Min number in list = {list.Min()}";
        Console.WriteLine(str);
   //      sw.WriteLine(str);
    });
    ParameterizedThreadStart avg = new ParameterizedThreadStart( (object obj) =>
    {
        var list = obj as List<int>;
        string str = $"Avg number in list = {list.Average()}";
        Console.WriteLine(str);
   //      sw.WriteLine(str);
    });

    Thread thread = new Thread(max);
    thread.Start(list);
    thread.Join();
    thread = new Thread(min);
    thread.Start(list);
    thread.Join();
    thread = new Thread(avg);
    thread.Start(list);
    thread.Join();
    Thread.Sleep(10000);
sw.Close();



