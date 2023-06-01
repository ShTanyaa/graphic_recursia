using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace рекурсия_индивидуальное_задание
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        private int size = 30;
        private int callCount = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private Point NextRandomPoint()
        {
            return new Point(rand.Next(size, Width - size * 2), rand.Next(size, Height - size * 2));
        }

        private Point Center(Point p)
        {
            return new Point(p.X + size / 2, p.Y + size / 2);
        }

        private Point DrawCircle(int callCount, Graphics g)
        {
            Point p = NextRandomPoint();
            g.DrawEllipse(Pens.Black, p.X, p.Y, size, size);

            if (callCount > 1)
            {
                g.DrawLine(Pens.Black, Center(p), Center(DrawCircle(callCount - 1, g)));
                g.DrawLine(Pens.Black, Center(p), Center(DrawCircle(callCount - 1, g)));
            }

            return p;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawCircle(callCount, e.Graphics);
        }
    }
}
