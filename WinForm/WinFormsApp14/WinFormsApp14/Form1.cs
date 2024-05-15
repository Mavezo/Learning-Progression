namespace WinFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }


        private Point GetNewCoord(Point center, long R, long i, long n)
        {
            int x = (int)(center.X + R * Math.Cos(2 * Math.PI * i / n));
            int y = (int)(center.Y + R * Math.Sin(2 * Math.PI * i / n));
            return new Point(x, y);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
    
        }
        long b = 500;
        long i = 1;
        int font = 2;



        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Random rd = new Random();
            for (int d = 1; d <= 60; d++)
            {
                Color cl = Color.FromArgb(rd.Next(1, 255), rd.Next(1, 255), rd.Next(1, 255), rd.Next(1, 255));
                Pen pen = new Pen(cl, font);
                Point center = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
                g.DrawLine(pen, GetNewCoord(GetNewCoord(center, GetNewCoord(center, 600, rd.Next(1, 1000), rd.Next(1, 1000)));
                i++;
                b++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            g.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            font++;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            font--;
        }
    }
}