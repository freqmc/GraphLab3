using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphLab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            MalevichPortraitOfWoman();
        }

        void MalevichPortraitOfWoman()
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.DarkGreen);
            

            Rectangle neck = new Rectangle(365, 200, 175, 250);
            g.FillRectangle(Brushes.BurlyWood, neck);

            Rectangle face = new Rectangle(325, -25, 250, 350);
            g.FillEllipse(Brushes.LightGoldenrodYellow, face);
            
            Brush hair = new SolidBrush(Color.DarkKhaki);
            int maxhairs = 27;
            for (int i = 0; i <= maxhairs; i++)
            {
                double t = (double)i / maxhairs;
                double angle = Math.PI * (1 - t);

                int centerX = face.X + face.Width/2;
                int centerY = face.Y + face.Height / 2;
                int radiusX = face.Width /2 ;
                int radiusY = -face.Height / 2;

                int x = (int)(centerX + radiusX * Math.Cos(angle));
                int y = (int)(centerY + radiusY * Math.Sin(angle));

                int elemWidth = 20;
                int elemHeight = 30;
                g.FillEllipse(hair, x - elemWidth / 2, y - elemHeight / 2, elemWidth, elemHeight);
            }

            Rectangle l_eyebrow = new Rectangle(360, 100, 50, 20);
            g.DrawArc(new Pen(Color.Black, 3), l_eyebrow, -2, -172);
            
            Rectangle lefteye = new Rectangle(360, 120, 60, 20);
            g.FillEllipse(Brushes.DarkSalmon, lefteye);
            Rectangle l_retina = new Rectangle(380, 123, 18, 15);
            g.FillEllipse(Brushes.Black, l_retina);

            Rectangle r_eyebrow = new Rectangle(480, 100, 50, 20);
            g.DrawArc(new Pen(Color.Black, 3), r_eyebrow, -2, -172);
            Rectangle righteye = new Rectangle(475, 120, 60, 20);
            g.FillEllipse(Brushes.DarkSalmon, righteye);
            Rectangle r_retina = new Rectangle(495, 123, 18, 15);
            g.FillEllipse(Brushes.Black, r_retina);
            Rectangle lips = new Rectangle(415, 240, 65, 25);
            g.FillPie(new SolidBrush(Color.SandyBrown), lips, 180, 360);
            g.FillPie(new SolidBrush(Color.Black), lips, 0, 180);
            Point[] leftnose = { new Point(445, 120), new Point(425, 215), new Point(445, 225)};
            Point[] rightnose = { new Point(445, 120), new Point(445, 225), new Point(465, 215) };
            g.FillPolygon(Brushes.BlanchedAlmond, leftnose);
            g.FillPolygon(Brushes.SandyBrown, rightnose);


            Rectangle redbody = new Rectangle(150, 375, 375, 300);
            g.FillRectangle(Brushes.DarkRed, redbody);
            g.FillEllipse(Brushes.DarkRed, new Rectangle(100, 375, 100, 300));


            Rectangle whitebody = new Rectangle(420, 375, 375, 300);
            g.FillRectangle(Brushes.GhostWhite, whitebody);
            g.FillEllipse(Brushes.GhostWhite, new Rectangle(750, 375, 100, 300));


            Rectangle bluecollar = new Rectangle(345, 350, 210, 50);
            g.FillRectangle(Brushes.DarkBlue, bluecollar);
            
        }
    }
}
