namespace SP_5__dz_lab_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mutex mutex = new Mutex(false, "forward");
            textBox1.Text = string.Empty;
            Task firstTask = Task.Run(() =>
            {
                Mutex mutex1 = Mutex.OpenExisting("forward");
                try
                {
                    mutex1.WaitOne();
                    for (int i = 0; i < 20; i++)
                    {
                        Thread.Sleep(100);
                        if (InvokeRequired)
                        {
                            BeginInvoke(() => { textBox1.Text += $"{i}\r\n"; });
                        }
                        else
                        {
                            textBox1.Text += $"\r\n{i}";
                        }

                    }
                }
                finally
                {
                    Thread.Sleep(100);
                    mutex1.ReleaseMutex();
                }

            });
            Thread.Sleep(100);
            Task secondTask = Task.Run(() =>
            {
                Mutex mutex = Mutex.OpenExisting("forward");
                mutex.WaitOne();
                try
                {
                    for (int i = 11; i > 1; --i)
                    {
                        Thread.Sleep(100);
                        if (InvokeRequired)
                        {
                            BeginInvoke(() => { textBox1.Text += $"{i}\r\n"; });
                        }
                        else
                            textBox1.Text += $"\r\n{i}";
                    }
                }
                finally
                {
                    mutex.ReleaseMutex();
                }

            });
        }

    }
}