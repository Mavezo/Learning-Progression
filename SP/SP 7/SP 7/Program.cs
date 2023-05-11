using SP_7;
// 5 forks, 5 philosophers




Fork[] forks= new Fork[5];
for (int i = 0; i < forks.Length; i++)
{
    forks[i] = new Fork();
}

Philosopher[] philosophers = new Philosopher[5];
for(int i = 0; i < philosophers.Length; i++)
{
    philosophers[i] = new Philosopher();
}

for(int i = 0; i < philosophers.Length; i++)
{
    philosophers[i].rightFork = forks[i];
    philosophers[i].leftFork= forks[(i + 1) % 5];
}

for (int i = 0; i < philosophers.Length; i++)
{
    Thread thread = new Thread((object obj) =>
    {
        int i = (int)(obj);
        Thread.Sleep(100);
        philosophers[i].Think(i);
    });
    thread.Start(i);
}

