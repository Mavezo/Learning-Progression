namespace SP_dz_lab_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            int power = int.Parse(textBox2.Text);
            Task<int> poweredNumber = Task.Run(() => Power(number, power));
            label1.Text = $"{number}^{power} = {(await poweredNumber)}";
        }

        private int Power(int number, int power)
        {
            int basis = number;
            for(int i = 1; i < power; i++)
            {
                number *= basis;
            }
            return number;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(textBox1.Text, out int text1) || textBox1.Text == "-")
            {
                if(int.TryParse(textBox2.Text, out int text2) || textBox2.Text == "-")
                {

                }
                else
                {
                    textBox2.Text = string.Empty;
                }
            }
            else
            {
                textBox1.Text = string.Empty;
            }
        }
    }
}