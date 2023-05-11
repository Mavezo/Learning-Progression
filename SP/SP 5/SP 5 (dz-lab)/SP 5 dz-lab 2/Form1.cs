using System.ComponentModel;

namespace SP_5_dz_lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BindingList<int> list = new BindingList<int>();
        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                list.Add(0);
            }
            listBox1.DataSource = list;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Mutex mutex = new Mutex(false, "forward");
            ParameterizedThreadStart firstThreadStart = new ParameterizedThreadStart((object obj) =>
            {
            Mutex mutex = Mutex.OpenExisting("forward");
            if (mutex.WaitOne())
            {
                try
                {
                    BindingList<int> list = (BindingList<int>)obj;
                    Random rand = new Random();
                        if (InvokeRequired)
                        {
                            Invoke(new Action(() =>
                            {
                                for (int i = 0; i < list.Count; i++)
                                {
                                    list[i] = list[i] + rand.Next(1, 10);
                                }
                            }));
                        }
                        else
                        {
                            for (int i = 0; i < list.Count; i++)
                            {
                                Thread.Sleep(100);
                                list[i] = list[i] + rand.Next(1, 10);
                            }
                        }
                    }
                    finally
                    {
                        mutex.ReleaseMutex();
                    }
                }
            });
            Thread firstThread = new Thread(firstThreadStart);
            firstThread.Start(list);
            //Thread.Sleep(100);
            ParameterizedThreadStart secondThreadStart = new ParameterizedThreadStart((object obj) =>
            {
                Mutex mutex = Mutex.OpenExisting("forward");
                if (mutex.WaitOne())
                {
                    try
                    {
                        BindingList<int> list = (BindingList<int>)obj;
                        int max = list[0];
                        int index = 0;
                        foreach (var item in list)
                        {
                            if (max < item)
                            {
                                max = item;
                                index = list.IndexOf(item);
                            }
                        }
                        MessageBox.Show($"Max number: {max} in {index + 1} index");
                    }
                    finally
                    {
                        mutex.ReleaseMutex();
                    }
                }
            });
            Thread secondThread = new Thread(secondThreadStart);
            secondThread.Start(list);


        }
    }
}