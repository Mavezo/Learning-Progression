List<int> array = new List<int>();
Random rand = new Random();    
for (int i = 0; i < 100; i++)
{
    array.Add(rand.Next(1, 101));
}

List<Task> tasks = new List<Task>();

Task taskMin = new Task((object obj) =>
{
    List<int> list= (List<int>)obj;
    Console.WriteLine($"Min: {list.Min()}");
}, array);
tasks.Add(taskMin);


Task taskMax = new Task((object obj) =>
{
    List<int> list = (List<int>)obj;
    Console.WriteLine($"Max: {list.Max()}");
}, array);
tasks.Add(taskMax);

Task taskAvg = new Task((object obj) =>
{
    List<int> list = (List<int>)obj;
    Console.WriteLine($"Average: {list.Average()}");
}, array);
tasks.Add(taskAvg);

Task taskSum = new Task((object obj) =>
{
    List<int> list = (List<int>)obj;
    int sum = 0;
    foreach (var item in list) 
    {
        sum += item;   
    }
    Console.WriteLine($"Sum: {sum}");
}, array);
tasks.Add(taskSum);


foreach (var item in tasks)
{
    item.Start();
}

Task.WaitAll(tasks.ToArray());

