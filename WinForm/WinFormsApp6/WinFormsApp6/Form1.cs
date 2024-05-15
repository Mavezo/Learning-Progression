namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            for (int i = 0;i < 100; i++)
            {
                progressBar1.PerformStep();
                Thread.Sleep(10);
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}