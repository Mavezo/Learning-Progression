
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace WinFormsApp11
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
            DrawGrafics();

        }

        private void DrawGrafics()
        {
            g = this.CreateGraphics();
            Pen pen = new Pen(Color.DarkSlateGray, 7f);
            pen.StartCap = LineCap.RoundAnchor;
            pen.EndCap = LineCap.ArrowAnchor;
            Point start = new Point(550, 560);
            Point end1 = new Point(550, 50);
            Point end2 = new Point(1140, 560);
            g.DrawLine(pen, start, end1);
            g.DrawLine(pen, start, end2);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"x:{e.X}, y:{e.Y}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            DrawGrafics();
            List<double> values = new List<double>();
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    double temp;
                    if (double.TryParse(control.Text, out temp))
                    {
                        values.Add(temp);
                    }
                }
            }
            if(values.Count > 0)
            {
                Label label1 = new Label();
                this.Controls.Add(label1);
                label1.Location = new Point(510, 80) ;
                label1.Text = values.Max().ToString();
                label1.Width = 35;
                label1.Height = 20;

             
            }
            int width = ((1110 - 600) -  (15 * (values.Count - 1))) / values.Count;
            //600 - start , 1090 - end
            //            Point start = new Point(550, 560);
            //            Point end1 = new Point(550, 50);
            //            Point end2 = new Point(1140, 560);

            Random rd = new Random();
            g = this.CreateGraphics();
            int xLocation = 600;
            int yLocation; 
           foreach (var item in values)
            {
                yLocation = (int)((557 * values.Max() / (values.Min() * 90)) * item);
                if (yLocation < 0)
                    yLocation = -yLocation;
                Label label = new Label();
                this.Controls.Add(label);
                label.Location = new Point(xLocation + width / 2, 590);
                label.Text = item.ToString();
                label.Width = 35;
                label.Height = 20;

                MessageBox.Show(item.ToString());
                if(yLocation < 0)
                {
                    yLocation = -yLocation;
                }

                Color color = Color.FromArgb(rd.Next(1, 255), rd.Next(1, 255), rd.Next(1, 255));
                Brush brush = new SolidBrush(color);
     
                Rectangle rect = new Rectangle(xLocation, yLocation, width, yLocation);
                xLocation += 15 + width;

                g.FillRectangle(brush, rect);



            }

        }
    }
}


//500 560; 

/*
             Graphics g = e.Graphics;
            Point point1 = new Point(0, 0);
            Size size1 = new Size(1820, 950);
            Rectangle rect1 = new Rectangle(point1, size1);
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(rect1);

            PathGradientBrush pthGrBrush1 = new PathGradientBrush(path);
            pthGrBrush1.CenterColor = Color.RebeccaPurple;
            Color[] colors1 = { Color.RoyalBlue, Color.IndianRed};
            pthGrBrush1.SurroundColors = colors1;
            Pen pen1 = new Pen(pthGrBrush1, 50f);
            g.DrawRectangle(pen1, rect1);

            PathGradientBrush pthGrBrush = new PathGradientBrush(path);
            pthGrBrush.CenterColor = Color.DarkViolet;
            Color[] colors = { Color.MediumVioletRed, Color.BlueViolet, Color.PaleVioletRed, Color.BlueViolet};
            pthGrBrush.SurroundColors = colors;
            Rectangle rectangle = new Rectangle(rect1.X + 25 , rect1.Y + 25, rect1.Width - 50, rect1.Height - 50); 
            e.Graphics.FillRectangle(pthGrBrush, rectangle);
 */