using ChainOfResponsibilityClasses;

namespace ChainOfResponsibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mass_TextBox.Clear();
            diameter_TextBox.Clear();
            totalAmount_TextBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(decimal.TryParse(mass_TextBox.Text.Replace('.', ','), out decimal mass))
            {
                if(decimal.TryParse(diameter_TextBox.Text.Replace('.', ','), out decimal diameter))
                {
                    Handler_10cent tenCent = new Handler_10cent();
                    Handler_20cent twentyCent = new Handler_20cent();
                    Handler_50cent fiftyCent = new Handler_50cent();
                    Handler_1euro oneEuro = new Handler_1euro();
                    Handler_2euro twoEuro = new Handler_2euro();
                    tenCent.successer = twentyCent;
                    twentyCent.successer = fiftyCent;
                    fiftyCent.successer = oneEuro;
                    oneEuro.successer = twoEuro;

                    decimal result = tenCent.HandleRequest(mass, diameter);
                    decimal.TryParse(totalAmount_TextBox.Text, out decimal total);
                    total += result;
                    totalAmount_TextBox.Text = total.ToString();

                }
                else MessageBox.Show("Wrong diameter");
            }
            else MessageBox.Show("Wrong mass");

            

        }
    }
}