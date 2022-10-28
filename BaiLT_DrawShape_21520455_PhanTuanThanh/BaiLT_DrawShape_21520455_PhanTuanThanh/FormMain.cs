using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BaiLT_DrawShape_21520455_PhanTuanThanh
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        Color color = Color.Black;
        private void buttonColor_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                buttonColor.BackColor = color;
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            if (splitContainer1.SplitterDistance > 405)
                splitContainer1.SplitterDistance = 405;
        }

        /*
            Min and max range of X: (10, 1450)
            Min and max range of Y: (120, 850)
         */

        Random rnd = new Random();

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            Graphics g = flowLayoutPanelDraw.CreateGraphics();
            SolidBrush brush = new SolidBrush(color);

            int x = rnd.Next(11, 1450);
            int y = rnd.Next(120, 850);
            int width = rnd.Next(101, 300);
            int height = rnd.Next(2, 100);

            Rectangle rect = new Rectangle(x, y, width, height);
            g.FillRectangle(brush, rect);   
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            Graphics g = flowLayoutPanelDraw.CreateGraphics();
            SolidBrush brush = new SolidBrush(color);

            int x1 = rnd.Next(11, 1450);
            int y1 = rnd.Next(120, 850);

            int x2 = rnd.Next(11, x1);
            int x3 = x1 + (x1 - x2);

            int y = rnd.Next(y1, 850);
            int y2 = y, y3 = y; 

            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);
            Point p3 = new Point(x3, y3);

            g.FillPolygon(brush, new Point[] { p1, p2, p3});  
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            Graphics g = flowLayoutPanelDraw.CreateGraphics();
            SolidBrush brush = new SolidBrush(color);

            int x = rnd.Next(11, 1450);
            int y = rnd.Next(120, 850);

            int rad = rnd.Next(2, 150);
            g.FillEllipse(brush, x, y, rad, rad);
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            Graphics g = flowLayoutPanelDraw.CreateGraphics();
            Pen pen = new Pen (color);

            int width = rnd.Next(3, 7);
            pen.Width = width;

            int x1 = rnd.Next(11, 1450);
            int y1 = rnd.Next(120, 850);
            int x2 = rnd.Next(11, 1450);
            int y2 = rnd.Next(120, 850);

            g.DrawLine(pen, x1, y1, x2, y2);
        }
    }
}
