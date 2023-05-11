using System.Diagnostics;
using System.Management;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParameterizedThreadStart threadStart = new ParameterizedThreadStart((object obj) =>
            {
                (int, int) var = ((int, int))obj;
                int? item1 = Convert.ToInt32(numericUpDown1.Value);
                if (var.Item1 == 0)
                {
                    item1 = 2;
                }
                int? item2 = Convert.ToInt32(numericUpDown2.Value);
                if (item2 == 0)
                {
                    for (int? i = item1; i <= item2; i++)
                    {
                        textBox1.Text = textBox1.Text + $"\r\n{i}";
                    }
                }
                else
                {
                    for (int? i = item1; ; i++)
                    {
                        textBox1.Text = textBox1.Text + $"\r\n{i}";
                    }
                }
            });
            Thread thread = new Thread(threadStart);
            thread.Start((Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value)));



        }
    }
}