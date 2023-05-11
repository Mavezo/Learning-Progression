namespace SP_4_lab_dz_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Task<long> fact = Task.Run(() =>
            {
                long res = 1;
                for(int i = 2; i <= numericUpDown1.Value; i++)
                {
                    res = res * i;
                }
                return res;
            });
            label1.Text = $"{numericUpDown1.Value}! = {(await fact).ToString()}";
        }
    }
}