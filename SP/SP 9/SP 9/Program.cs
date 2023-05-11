using System.Diagnostics;

static long Factorial(long x, long initial)
{
    Console.WriteLine($"Start count {initial} in {Thread.CurrentThread.ManagedThreadId} thread");
    if (x == 1)
        return 1;
    else
        return x * Factorial(x - 1, x);
}
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
List<long> list = new List<long>() { 55, 50, 55, 44, 44 };
var results  = list
    //.AsParallel()
    .Select(x=> new {X = x, Res = Factorial(x, x)})
    .ToList();  
foreach (var result in results)
{
    Console.WriteLine($"{result.X}! = {result.Res}");
}
stopwatch.Stop();
Console.WriteLine(stopwatch.Elapsed);





