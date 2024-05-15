using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point center = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
            int seconds = DateTime.Now.Second;
            int min = DateTime.Now.Minute;
            int hours = DateTime.Now.Hour;
            Pen penS = new Pen(Color.DarkMagenta, 3.0f);
            Pen penM = new Pen(Color.Black, 3.0f);
            Pen penH = new Pen(Color.Red, 3.0f);
            Point toPS = GetNewCoord(center, 120, seconds - 15, 60);
            Point toPM = GetNewCoord(center, 100, min - 15, 60);
            Point toPH = GetNewCoord(center, 80, hours - 15, 12);
            for (int i = 1; i <= 60; i++)
            {
                if (i % 5 == 0)
                {
                    g.DrawLine(Pens.Red, GetNewCoord(center, 100, i, 60), GetNewCoord(center, 140, i, 60));
                }
                else
                {
                    g.DrawLine(Pens.LightBlue, GetNewCoord(center, 100, i, 60), GetNewCoord(center, 120, i, 60));
                }
            }
            g.DrawLine(penS, center, toPS);
            g.DrawLine(penM, center, toPM);
            g.DrawLine(penH, center, toPH);
            g.Dispose();
        }


        private Point GetNewCoord(Point center, int R, int i, int n)
        {
            int x = (int)(center.X + R * Math.Cos(2 * Math.PI * i / n));
            int y = (int)(center.Y + R * Math.Sin(2 * Math.PI * i / n));
            return new Point(x, y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
            Invalidate();
        }
    }
}