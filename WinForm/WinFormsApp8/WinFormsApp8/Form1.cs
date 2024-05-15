namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int w;
        int h;
        int x;
        int y;
        List<Point> lp = new List<Point>();
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            lp.Add(point);
            w = h = 500;
            x = e.X - (w / 2);
            y = e.Y - (h / 2);
            Graphics graphics = CreateGraphics();
            graphics.Clear(BackColor);
            graphics.DrawArc(Pens.BlueViolet, x, y, w, h, 10 , 10);
            graphics.Dispose();
        }
    }
}