Thread threadTimer = new Thread(() =>
{
    int totalSecondsCount = 0;
    while (true)
    {
        Thread.Sleep(1000);
        totalSecondsCount++;
        Console.WriteLine(totalSecondsCount);
    }
});
threadTimer.Start();
while (true)
{
    if (threadTimer.ThreadState == ThreadState.WaitSleepJoin)
    {
        Thread.Sleep(500);
        Console.WriteLine("Говнокод");
    }
}

