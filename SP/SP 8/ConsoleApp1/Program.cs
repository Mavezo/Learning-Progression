List <int> array = new List<int>();
Random rand = new Random();
for (int i = 0; i < 100; i++)
{
    array.Add(rand.Next(1, 101));
}

Console.WriteLine();
Console.WriteLine();

Task<List<int>> task = new Task<List<int>>((object obj) =>
{
    List<int> array = (List<int>)obj;
    array = array.Distinct().ToList();
    return array;
}, array);
task.Start();
task.Wait();
task.ContinueWith(next =>
{
    next.Result.Sort();
    for (int i = 0; i < next.Result.Count; i++)
    {
        Console.WriteLine(next.Result[i]);
    }
    return next.Result;
});
task.Wait();  
//Not proud about that below
int arg = 50;
task.ContinueWith(next => {
    //int Arg = Convert.ToInt32(arg);
    Console.WriteLine($"{next.Result.IndexOf(arg)} - {arg}");
});

task.Wait();


Console.ReadLine();