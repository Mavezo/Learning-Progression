namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void alpha_Scroll(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(trackBar1.Value, 0, trackBar2.Value, 0);
        }

        private void Color_Scroll(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(trackBar1.Value, 1, trackBar2.Value, 1);
        }

    }
}