using System.Diagnostics;

Console.WriteLine("Hello, World!");
Process process1 = Process.GetCurrentProcess();
Console.WriteLine($"ProcessID: {process1.Id}");
Console.WriteLine($"BasePriority: {process1.BasePriority}");
Console.WriteLine($"BasePriority: {process1.PriorityClass}");
Console.WriteLine($"ProcessName: {process1.ProcessName}");
Console.WriteLine($"MachineName: {process1.MachineName}");
Console.WriteLine($"Main Window Title: {process1.MainWindowTitle}");


