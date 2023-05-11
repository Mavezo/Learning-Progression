using System;

Task taskStart = new Task(() =>
{
    DateTime currentDate = DateTime.Now;
    Console.WriteLine("Task.Start(): {1:d}  {0:t}", currentDate.TimeOfDay, currentDate.Date);
});
taskStart.Start();

Task taskRun = Task.Run(() =>
{
    DateTime currentDate = DateTime.Now;
    Console.WriteLine("Task.Run(): {1:d}  {0:t}", currentDate.TimeOfDay, currentDate.Date);
});

Task tastFactory = Task.Factory.StartNew(() =>
{
    DateTime currentDate = DateTime.Now;
    Console.WriteLine("Task.Factory.StartNew(): {1:d}  {0:t}", currentDate.TimeOfDay, currentDate.Date);
});

Console.ReadLine();