using System.Runtime.CompilerServices;

Console.WriteLine("enter start number");
int startNumber = int.Parse(Console.ReadLine());
Console.WriteLine("enter end number");
int endNumber = int.Parse(Console.ReadLine());
Console.WriteLine();


Task task = new Task((object? obj) =>
{
    (int, int) tuple = ((int, int))obj;

    for (int i = tuple.Item1; i < tuple.Item2; i++)
    {
        for (int j = 2; j < i; j++)
        {
            if (i % j == 0)
            {
                break;
            }
            if (j == i - 1)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}, (startNumber, endNumber));
task.Start();
task.Wait();

//Task task = Task.Run(() =>
//{
//    for (int i = 0; i < 1000; i++)
//    {
//        for (int j = 2; j < i; j++)
//        {
//            if (i % j == 0)
//            {
//                break;
//            }
//            if (j == i - 1)
//            {
//                Console.WriteLine($"{i}");
//            }
//        }
//    }
//});
//task.Wait();