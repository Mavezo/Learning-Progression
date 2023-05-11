using static System.Windows.Forms.DataFormats;
using System.DirectoryServices.ActiveDirectory;

namespace SP_4_lab_dz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart threadStartNumbers = new ThreadStart(() =>
            {
                Random rand = new Random();
                for (; ; )
                {
                    try
                    {
                        Thread.Sleep(35);
                        if (InvokeRequired)
                        {
                            Invoke(() =>
                            {
                                label1.Text = rand.Next(1, 999).ToString();
                            });
                        }
                        else
                        {
                            label1.Text = rand.Next(1, 999).ToString();
                        }
                    }
                    catch { }
                }
            });
            Thread numbers = new Thread(threadStartNumbers);
            numbers.Priority = (ThreadPriority)comboBox1.SelectedItem;
            numbers.IsBackground = true;
            numbers.Start();

            ThreadStart threadStartLetters = new ThreadStart(() =>
            {
                Random rand = new Random();
                for (; ; )
                {
                    try
                    {
                        Thread.Sleep(35);
                        if (InvokeRequired)
                        {
                            Invoke(() =>
                            {
                                string text = ((char)rand.Next(97, 122)).ToString() + ((char)rand.Next(65, 90)).ToString() + ((char)rand.Next(97, 122)).ToString();
                                label2.Text = text;
                            });
                        }
                        else
                        {
                            string text = ((char)rand.Next(97, 122)).ToString() + ((char)rand.Next(65, 90)).ToString() + ((char)rand.Next(97, 122)).ToString();
                            label2.Text = text;
                        }
                    }
                    catch
                    {

                    }
                }


            });
            Thread letters = new Thread(threadStartLetters);
             letters.Priority = (ThreadPriority)comboBox2.SelectedItem;
             letters.IsBackground= true;
             letters.Start();


            ThreadStart threadStartSymbols = new ThreadStart(() =>
            {
                Random rand = new Random();
                for (; ; )
                {
                    try
                    {
                        Thread.Sleep(35);
                        if (InvokeRequired)
                        {
                            Invoke(() =>
                            {
                                string text = ((char)rand.Next(33, 47)).ToString() + ((char)rand.Next(33, 47)).ToString() + ((char)rand.Next(33, 47)).ToString();
                                label3.Text = text;
                            });
                        }
                        else
                        {
                            string text = ((char)rand.Next(33, 47)).ToString() + ((char)rand.Next(33, 47)).ToString() + ((char)rand.Next(33, 47)).ToString();
                            label3.Text = text;
                        }
                    }
                    catch
                    {

                    }
                }


            });
            Thread symbols = new Thread(threadStartSymbols);
            symbols.Priority = (ThreadPriority)comboBox3.SelectedItem;
            symbols.IsBackground = true;
            symbols.Start();



        }


        private void Form1_Load(object sender, EventArgs e)
        {

            //Lowest = 0,
            //BelowNormal = 1,
            //Normal = 2,
            //AboveNormal = 3,
            //Highest = 4

            comboBox1.DataSource = Enum.GetValues(typeof(ThreadPriority));
            comboBox2.DataSource = Enum.GetValues(typeof(ThreadPriority));
            comboBox3.DataSource = Enum.GetValues(typeof(ThreadPriority));


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}