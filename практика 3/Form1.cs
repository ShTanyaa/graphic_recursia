using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace практика_3
{
    public partial class Form1 : Form
    {
        private int size =35;
        private int callCount = 3;
        int i = 1;
        int j = 1;
        int x1, y1,x2,y2 = 0;
        Graphics gg;
        Random rnd=new Random();
        int stepx = 5;
        int stepy = 5;
        Pen bluePen = new Pen(Color.Blue, 2);
        Pen YellowPen = new Pen(Color.Yellow, 6);
        Pen PurplePen = new Pen(Color.Purple, 5);
        Pen GreenPen = new Pen(Color.Green,4);
        Pen LiteBlue = new Pen(Color.LightBlue);
        Pen Black = new Pen(Color.Black);
        Pen Orange = new Pen(Color.Orange,3);
        public Form1()
        {
            InitializeComponent();
        }

        private void заданифToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void линияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen redPen = new Pen(Color.Red,3);
            g.DrawLine(redPen,100,40,100,140);
            g.DrawLine(bluePen, 25, 70, 225, 70);
            g.Dispose();
        }

        private void прямоугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawRectangle(YellowPen, 250, 35, 300, 200);
            g.FillRectangle(Brushes.GreenYellow, 100, 100, 300, 300);
            g.FillRectangle(Brushes.GreenYellow, 100, 100, 300, 300);
            g.Dispose();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
            g.Dispose();
        }

        private void окружностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawEllipse(Pens.Purple, 250, 35, 200, 200);
            g.Dispose();
        }

        private void треугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point[] treug = { new Point(200, 100), new Point(10, 40), new Point(45, 100) };
            Graphics g = this.CreateGraphics();
            g.DrawPolygon(GreenPen, treug);
        }

        private void трапецияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point[] trap = { new Point(150, 60), new Point(300, 60), new Point(500, 200),new Point(40,200) };
            Graphics g = this.CreateGraphics();
            g.FillPolygon(Brushes.GreenYellow, trap);
        }

        private void шестиугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point[] sh = { new Point(300, 200), new Point(350, 200), new Point(375, 245),  new Point(350, 285),new Point(300, 285), new Point(275, 245) };
            Graphics g = this.CreateGraphics();
            g.FillPolygon(Brushes.GreenYellow, sh);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int x1 = 70;
            int y1 = 70;
            int x2 = 140;
            int y2 = 140;
            Graphics g = this.CreateGraphics();
            for(int i=1;i<=3;i++)
            {
                g.DrawRectangle(bluePen,x1, y1, x2, y2);
                x1 += 5;y1 += 5;x2 -= 10;y2 -=10;
            }
            g.Dispose();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.LightGray);
            g.DrawEllipse(Pens.LightBlue, 100, 240, 180, 180);
            g.FillEllipse(Brushes.LightBlue, 100, 240, 180, 180);

            g.DrawEllipse(Pens.LightBlue, 112, 115, 150, 150);
            g.FillEllipse(Brushes.LightBlue, 112, 115, 150, 150);

            g.DrawEllipse(Pens.LightBlue, 142, 35, 90, 90); 
            g.FillEllipse(Brushes.LightBlue, 142, 35, 90, 90);

            g.DrawEllipse(Pens.Black, 204, 65, 10, 10);
            g.FillEllipse(Brushes.Black, 204, 65, 10, 10);

            g.DrawEllipse(Pens.Black, 166, 65, 10, 10);
            g.FillEllipse(Brushes.Black, 166, 65, 10, 10);

            Point[] treug = { new Point(230, 230), new Point(50, 40), new Point(35, 80) };
            Graphics g1 = this.CreateGraphics();
            g1.FillPolygon(Brushes.Orange, treug);

            Point[] trg = { new Point(170, 80), new Point(450, 80), new Point(185, 95) };
            Graphics g2 = this.CreateGraphics();
            g2.FillPolygon(Brushes.Orange, trg);

            Point[] el = { new Point(350, 370), new Point(450, 370), new Point(400, 250) };
            Graphics g3 = this.CreateGraphics();
            g3.FillPolygon(Brushes.Green, el);

            Point[] el1 = { new Point(350, 250), new Point(450, 250), new Point(400, 170) };
            Graphics g4 = this.CreateGraphics();
            g4.FillPolygon(Brushes.Green, el1);

            Point[] el2 = { new Point(350, 170), new Point(450, 170), new Point(400, 90) };
            Graphics g5 = this.CreateGraphics();
            g5.FillPolygon(Brushes.Green, el2);

            g.Dispose();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.FillEllipse(Brushes.Black, i, j, 20, 20);
            Thread.Sleep(10);
            g.Clear(Color.WhiteSmoke);
            if (j + stepy > 430 || j + stepy < 1) stepy = -stepy;
            if (i + stepx > 780 || i + stepx < 1) stepx = -stepx;

            i = i + stepx;
            j = j + stepy;
            g.Dispose();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(bluePen, 408, 10, 408, 489);
            g.DrawLine(bluePen, 0, 229, 816, 229);
            for(int i=-50;i<50;i++)
            {
                int x = i;
                int x1 = x - 1;
                double y = Math.Pow(x, 2);
                double y1 = Math.Pow(x1, 2);
                g.DrawLine(Black, x1 + 408, -(int)y1 + 229, x + 408, -(int)y + 229);
            }
            g.Dispose();
           

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(Black, 408, 10, 408, 489);
            g.DrawLine(Black, 0, 229, 816, 229);
            for (int i = -500; i < 500; i++)
            {
                if (i != 0)
                {
                    int x = i + 10;
                    int x1 = x - 1;
                    double y = 100*Math.Sin(x*0.02);
                    double y1 = 100*Math.Sin(x1*0.02);
                    g.DrawLine(LiteBlue, x1 + 408, -(int)y1 + 229, x + 408, -(int)y + 229);
                }
            }
            g.Dispose();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(bluePen, 408, 10, 408, 489);
            g.DrawLine(bluePen, 0, 229, 816, 229);
            for (int i = -50; i < 50; i++)
            {
                int x = i;
                int x1 = x - 1;
                double y = Math.Pow(x, 3);
                double y1 = Math.Pow(x1, 3);
                g.DrawLine(Black, x1 + 408, -(int)y1 + 229, x + 408, -(int)y + 229);
            }
            g.Dispose();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
        private bool isMouse = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Gray);
            int[] mas1 = new int[20];
            int[] mas2 = new int[20];
            for (int i = 0; i < mas1.Length; i++)
            {
                mas1[i] = rnd.Next(10, 700);

            }
            for (int i = 0; i < mas2.Length; i++)
            {
                mas2[i] = rnd.Next(10, 700);

            }
            for (int i = 0; i < 20; i++)
            {
                g.DrawLine(LiteBlue, mas1[i], mas2[i], mas1[i], mas2[i] +20);
            }
            g.Dispose();
        }

        private void z1( int x, int y)
        {
            Graphics g = this.CreateGraphics();
            if (y == 0)
            {

            }
            else
            {
                g.DrawEllipse(GreenPen, x, x, y, y);
                z1(x+10,y-20);
            }
           
            
        }
        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            int x = 100;int y = 300;
            z1(x,y);
        }
        private Point z6()
        {
            Graphics g=this.CreateGraphics();
            return new Point (rnd.Next(size, Width - size * 2), rnd.Next(size, Height - size * 2));
        }
        private Point Center(Point p)
        {
            return new Point(p.X + size / 2, p.Y + size / 2);
        }
        private Point DrawCircle(int callCount, Graphics g)
        {
            Point p = z6();
            g.DrawEllipse(Pens.Black, p.X, p.Y, size, size);

            if (callCount > 1)
            {
                g.DrawLine(bluePen, Center(p), Center(DrawCircle(callCount-1, g)));
                g.DrawLine(bluePen, Center(p), Center(DrawCircle(callCount-1, g)));
            }

            return p;
        }
        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            DrawCircle(callCount,g);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse = false;
        }

       
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;
            gg = this.CreateGraphics();
            Pen myPen = new Pen(Color.Black);
            if(isMouse==true)
            {
                gg.DrawLine(myPen, x1, y1, x2, y2);
                x1 = x2;
                y1 = y2;
            }
            gg.Dispose();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
            isMouse = true;
        }
    }
}
