using System.Diagnostics;

namespace SP_Dz1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //using (Process process = new Process())
            //{
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo("C:\\Users\\mavez\\source\\repos\\SP Dz1\\ConsoleApp1\\bin\\Debug\\net6.0\\ConsoleApp1.exe");
            process.StartInfo.ArgumentList.Add("C:\\Users\\mavez\\OneDrive\\Робочий стіл\\kod z23.txt");
            process.StartInfo.ArgumentList.Add("c");
            process.StartInfo.RedirectStandardOutput= true;
            process.Start();
            if (checkBox1.Checked)
            {
                process.WaitForExit();
            }
                string output = process.StandardOutput.ReadToEnd();
                MessageBox.Show(output);

        }


    }
}