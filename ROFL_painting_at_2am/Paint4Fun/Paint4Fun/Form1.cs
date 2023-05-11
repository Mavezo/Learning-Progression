using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;



namespace Paint4Fun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics= e.Graphics;
            
        }

        bool mouseDown = false;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown= true;
        }

        public void DrawHuman(Point e)
        {
            Graphics graphics = this.CreateGraphics();
            Random rand = new Random();
            Pen pen = new Pen(Color.FromArgb(rand.Next(1, 255), rand.Next(1, 255), rand.Next(1, 255)), 1);
            Point[] points = new Point[] {new Point(e.X- 20, e.Y - 40) ,
                new Point(e.X, e.Y) ,
                new Point(e.X + 20, e.Y - 40) ,
                new Point(e.X, e.Y) ,
                new Point(e.X, e.Y + 40) ,
                new Point(e.X - 40, e.Y + 60) ,
                new Point(e.X, e.Y + 40) ,
                new Point(e.X+ 40, e.Y + 60) ,
                new Point(e.X, e.Y + 40) ,
                new Point(e.X, e.Y + 60) ,
                new Point(e.X - 10, e.Y + 60) ,
                new Point(e.X - 10, e.Y + 100) ,
                new Point(e.X + 10, e.Y + 100) ,
                new Point(e.X + 10, e.Y + 60) ,
                new Point(e.X, e.Y + 60)
            };
            graphics.DrawLines(pen, points);


        }

        private void DrawCloverLeaf(Graphics graphics, int x, int y, int size, Pen pen)
        {
            int quarterSize = size / 4;

            // Draw stem
            graphics.DrawLine(pen, x + quarterSize * 2, y + size, x + quarterSize * 2, y + size * 3);

            // Draw top leaf
            Point[] topLeafPoints = new Point[10];
            topLeafPoints[0] = new Point(x, y + quarterSize * 3);
            topLeafPoints[1] = new Point(x + quarterSize * 2, y);
            topLeafPoints[2] = new Point(x + quarterSize * 4, y + quarterSize * 2);
            topLeafPoints[3] = new Point(x + size, y + quarterSize * 2);
            topLeafPoints[4] = new Point(x + size - quarterSize * 2, y + size);
            topLeafPoints[5] = new Point(x + size - quarterSize, y + size - quarterSize);
            topLeafPoints[6] = new Point(x + size - quarterSize * 3, y + size - quarterSize * 3);
            topLeafPoints[7] = new Point(x + quarterSize * 2, y + size - quarterSize);
            topLeafPoints[8] = new Point(x + quarterSize, y + size - quarterSize * 3);
            topLeafPoints[9] = new Point(x + quarterSize * 3, y + quarterSize);

            graphics.DrawPolygon(pen, topLeafPoints);

            // Draw bottom leaf
            Point[] bottomLeafPoints = new Point[10];
            bottomLeafPoints[0] = new Point(x + quarterSize * 2, y + size);
            bottomLeafPoints[1] = new Point(x, y + size - quarterSize * 3);
            bottomLeafPoints[2] = new Point(x + quarterSize, y + size - quarterSize);
            bottomLeafPoints[3] = new Point(x + quarterSize * 3, y + quarterSize * 3);
            bottomLeafPoints[4] = new Point(x + size - quarterSize * 3, y + quarterSize * 3);
            bottomLeafPoints[5] = new Point(x + size - quarterSize, y + quarterSize);
            bottomLeafPoints[6] = new Point(x + size - quarterSize * 2, y + quarterSize * 2);
            bottomLeafPoints[7] = new Point(x + quarterSize * 4, y + size - quarterSize);
            bottomLeafPoints[8] = new Point(x + quarterSize * 2, y + size - quarterSize * 2);
            bottomLeafPoints[9] = new Point(x + quarterSize * 3, y + size - quarterSize * 3);

            graphics.DrawPolygon(pen, bottomLeafPoints);
        }

        public void DrawCubes(Point e)
        {
            Graphics graphics = this.CreateGraphics();
            Random rand = new Random(); 
            Pen pen = new Pen(Color.FromArgb(rand.Next(1, 255), rand.Next(1, 255), rand.Next(1, 255)), 1);
            Point[] points = new Point[] {
                new Point(e.X - 30, e.Y - 30),
                new Point(e.X + 30, e.Y - 30),
                new Point(e.X - 30, e.Y - 30),
                new Point(e.X - 30, e.Y + 30),
                new Point(e.X + 30, e.Y + 30),
                new Point(e.X + 60, e.Y + 60),
                new Point(e.X + 30, e.Y + 30),
                new Point(e.X + 30, e.Y - 30),
                new Point(e.X + 60, e.Y),
                new Point(e.X + 60, e.Y + 60),
                new Point(e.X, e.Y + 60),
                new Point(e.X - 30, e.Y + 30),
            };
            graphics.DrawLines(pen, points);

            
            //Brush brush = Brushes.LightSalmon;
            //Rectangle rectangle = new Rectangle(e.X, e.Y, 20, 20);
            //graphics.FillEllipse(brush, rectangle);
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void DrawOwl(Graphics graphics, int x, int y, int size, Pen pen)
        {
            // Draw body
            graphics.DrawEllipse(pen, x, y + size / 4, size, size / 2);

            // Draw head
            int headSize = size / 2;
            graphics.DrawEllipse(pen, x + size / 4, y, headSize, headSize);

            // Draw eyes
            int eyeSize = headSize / 4;
            graphics.FillEllipse(Brushes.DarkBlue, x + size / 4 + eyeSize / 2, y + eyeSize, eyeSize, eyeSize);
            graphics.FillEllipse(Brushes.MediumPurple, x + size / 4 + headSize - eyeSize * 1.5f, y + eyeSize, eyeSize, eyeSize);

            // Draw beak
            Point[] beakPoints = new Point[3];
            beakPoints[0] = new Point(x + size / 2, y + headSize / 2);
            beakPoints[1] = new Point(x + size / 2 + headSize / 8, y + headSize * 3 / 4);
            beakPoints[2] = new Point(x + size / 2 - headSize / 8, y + headSize * 3 / 4);
            graphics.FillPolygon(Brushes.Yellow, beakPoints);

            // Draw wings
            int wingSize = size * 3 / 4;
            Point[] leftWingPoints = new Point[4];
            leftWingPoints[0] = new Point(x - size / 4, y + size / 4 + size / 8);
            leftWingPoints[1] = new Point(x - size / 8, y + size / 4 - size / 8);
            leftWingPoints[2] = new Point(x + size / 8, y + size / 4 - size / 8);
            leftWingPoints[3] = new Point(x - size / 8, y + size / 4 + size / 8);
            graphics.DrawPolygon(pen, leftWingPoints);

            Point[] rightWingPoints = new Point[4];
            rightWingPoints[0] = new Point(x + size + size / 4, y + size / 4 + size / 8);
            rightWingPoints[1] = new Point(x + size + size / 8, y + size / 4 - size / 8);
            rightWingPoints[2] = new Point(x + size - size / 8, y + size / 4 - size / 8);
            rightWingPoints[3] = new Point(x + size + size / 8, y + size / 4 + size / 8);
            graphics.DrawPolygon(pen, rightWingPoints);

            // Draw feet
            graphics.DrawLine(pen, x + size / 2 - size / 16, y + size * 3 / 4, x + size / 2 - size / 8, y + size);
            graphics.DrawLine(pen, x + size / 2 + size / 16, y + size * 3 / 4, x + size / 2 + size / 8, y + size);
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Random rand = new Random();
                Pen pen = new Pen(Color.FromArgb(rand.Next(1, 255), rand.Next(1, 255), rand.Next(1, 255)), 10);
                DrawOwl(this.CreateGraphics(), e.X, e.Y, 800, pen);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int x = 0; x < this.ClientSize.Width; x++)
            {
                for(int y = 0; y < this.ClientSize.Height; y++) { 
                
                    Random rand = new Random();
                    if(x %  rand.Next(50, 200) == 0 && y % rand.Next(50, 200) == 0)
                    {
                        DrawCubes(new Point(x, y));
                        
                    }
                
                
                
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.Black);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < this.ClientSize.Width; x++)
            {
                for (int y = 0; y < this.ClientSize.Height; y++)
                {

                    Random rand = new Random();
                    if (x % rand.Next(50, 200) == 0 && y % rand.Next(50, 200) == 0)
                    {
                        DrawHuman(new Point(x, y));

                    }



                }
            }
        }

        private void DrawStar(Graphics graphics, Pen pen, int x, int y, int width, int height, int points)
        {
            Point[] outerPoints = new Point[points * 2];
            Point[] innerPoints = new Point[points * 2];
            int halfWidth = width / 2;
            int halfHeight = height / 2;
            double angle = Math.PI / points;

            for (int i = 0; i < points * 2; i += 2)
            {
                double outerX = x + halfWidth * Math.Cos(i * angle);
                double outerY = y + halfHeight * Math.Sin(i * angle);
                double innerX = x + halfWidth / 2 * Math.Cos((i + 1) * angle);
                double innerY = y + halfHeight / 2 * Math.Sin((i + 1) * angle);

                outerPoints[i] = new Point((int)outerX, (int)outerY);
                innerPoints[i] = new Point((int)innerX, (int)innerY);

                outerX = x + halfWidth / 2 * Math.Cos((i + 2) * angle);
                outerY = y + halfHeight / 2 * Math.Sin((i + 2) * angle);
            }
            graphics.DrawPolygon(pen, outerPoints);
            graphics.DrawPolygon(pen, innerPoints);
        }

    private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
     
        }
    }
}