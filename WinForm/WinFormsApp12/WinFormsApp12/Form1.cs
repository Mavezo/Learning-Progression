namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
        }

        bool IsClicked = false;
        bool IsUnclicked = true;
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            IsClicked = false;
            IsUnclicked = true;

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            IsClicked = true;
            IsUnclicked = false;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsClicked && IsUnclicked == false) 
            {
                g = this.CreateGraphics();
                Random rd = new Random();
                Color color =  Color.FromKnownColor((KnownColor)rd.Next(0, 180));
                SolidBrush brush = new SolidBrush(color);
                Rectangle rect = new Rectangle(e.Location, new Size(55, 55));
                g.FillEllipse(brush, rect);
            } 
        }
    }
}