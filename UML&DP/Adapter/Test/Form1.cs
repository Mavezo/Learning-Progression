using Adapter;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hole_TextBox.Text = hole_TextBox.Text.Replace('.', ',');
            square_TextBox.Text = square_TextBox.Text.Replace('.', ',');

            if(!(string.IsNullOrEmpty(hole_TextBox.Text) && string.IsNullOrEmpty(square_TextBox.Text))){
                if(double.TryParse(hole_TextBox.Text, out double hole)) 
                {
                    if (double.TryParse(square_TextBox.Text, out double square)){
                        RoundHole roundHole = new RoundHole(hole);
                        SquarePegAdapter squarePegAdapter = new SquarePegAdapter(new SquarePeg(square));
                        if (roundHole.Fits(squarePegAdapter))
                            MessageBox.Show("Peg fits!");
                        else
                            MessageBox.Show("Peg doesn't fit");
                    }
                    else MessageBox.Show("Wrong square width");
                }
                else MessageBox.Show("Wrong Hole Radius");

            }

        }
    }
}