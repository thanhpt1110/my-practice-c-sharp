using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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

        /*
            Min and max range of Panel's width: (10, 1450)
            Min and max range of Panel's height: (120, 850)
         */
        // Declare Varibles 
        int StartX = 11, StartY = 121;
        int MaxWidth, MaxHeight;
        Color color = Color.Black;
        Random rnd = new Random();
        private List<Shape> Shapes = new List<Shape>();


        // Process Sidebar
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
            if (splitContainer1.SplitterDistance > 370)
                splitContainer1.SplitterDistance = 370;
            if (splitContainer1.SplitterDistance < 220)
                splitContainer1.SplitterDistance = 220;
        }


        // Process click button to draw
        private void buttonLine_Click(object sender, EventArgs e)
        {
            MaxWidth = this.flowLayoutPanelDraw.Width;
            MaxHeight = this.flowLayoutPanelDraw.Height;

            int width = rnd.Next(3, 7);
            int x1 = rnd.Next(StartX, MaxWidth);
            int y1 = rnd.Next(StartY, MaxHeight);
            int x2 = rnd.Next(x1 + 20, x1 + 100);
            int y2 = rnd.Next(y1 + 20, y1 + 100);

            this.Shapes.Add(new MLine(x1, y1, x2, y2, width, color));
            this.flowLayoutPanelDraw.Invalidate();
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            MaxWidth = this.flowLayoutPanelDraw.Width;
            MaxHeight = this.flowLayoutPanelDraw.Height;

            int x = rnd.Next(StartX, MaxWidth);
            int y = rnd.Next(StartY, MaxHeight);
            int width = rnd.Next(75, 125);
            int height = rnd.Next(25, 75);

            this.Shapes.Add(new MRectangle(x, y, width, height, color));
            this.flowLayoutPanelDraw.Invalidate();
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            MaxWidth = this.flowLayoutPanelDraw.Width;
            MaxHeight = this.flowLayoutPanelDraw.Height;

            int x = rnd.Next(StartX, MaxWidth);
            int y = rnd.Next(StartY, MaxHeight);
            int rad = rnd.Next(20, 100);

            this.Shapes.Add(new MCircle(x, y, rad, color));
            this.flowLayoutPanelDraw.Invalidate();
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            MaxWidth = this.flowLayoutPanelDraw.Width;
            MaxHeight = this.flowLayoutPanelDraw.Height;

            int x1 = rnd.Next(StartX, MaxWidth);
            int y1 = rnd.Next(StartY, MaxHeight);

            int x2 = rnd.Next(x1 - 100, x1);
            int x3 = x1 + (x1 - x2);

            int y = rnd.Next(y1, y1 + 100);
            int y2 = y, y3 = y;

            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);
            Point p3 = new Point(x3, y3);

            this.Shapes.Add(new MTriangle(p1, p2, p3, color));
            this.flowLayoutPanelDraw.Invalidate();
        }

        private void flowLayoutPanelDraw_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < Shapes.Count; ++i)
            {
                Shapes[i].Draw(e.Graphics);
            }
        }
    }

    abstract class Shape
    {
        public abstract void Draw(Graphics g);
    }

    class MLine : Shape
    {
        private int x1, y1, x2, y2, penWidth;
        private Color color;

        public MLine(int x1, int y1, int x2, int y2, int penWidth, Color color)
        {
            this.X1 = x1;
            this.Y1 = y1;
            this.X2 = x2;
            this.Y2 = y2;
            this.PenWidth = penWidth;
            this.Color = color;
        }

        public int X1 { get => x1; set => x1 = value; }
        public int Y1 { get => y1; set => y1 = value; }
        public int X2 { get => x2; set => x2 = value; }
        public int Y2 { get => y2; set => y2 = value; }
        public int PenWidth { get => penWidth; set => penWidth = value; }
        public Color Color { get => color; set => color = value; }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(this.color);
            pen.Width = this.penWidth;
            g.DrawLine(pen, this.x1, this.y1, this.x2, this.y2);
        }
    }

    class MRectangle : Shape
    {
        private int x, y, width, height;
        private Color color;

        public MRectangle(int x, int y, int width, int height, Color color)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.Color = color;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public Color Color { get => color; set => color = value; }

        public override void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(this.color), x, y, width, height);
        }
    }

    class MCircle : Shape
    {
        private int x, y, rad;
        private Color color;

        public MCircle(int x, int y, int rad, Color color)
        {
            this.X = x;
            this.Y = y;
            this.Rad = rad;
            this.Color = color;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Rad { get => rad; set => rad = value; }
        public Color Color { get => color; set => color = value; }

        public override void Draw(Graphics g)
        {
            g.FillEllipse(new SolidBrush(this.color), x, y, rad, rad);
        }
    }

    class MTriangle : Shape
    {
        private Point p1, p2, p3;
        private Color color;

        public MTriangle(Point p1, Point p2, Point p3, Color color)
        {
            this.P1 = p1;
            this.P2 = p2;
            this.P3 = p3;
            this.Color = color;
        }

        public Point P1 { get => p1; set => p1 = value; }
        public Point P2 { get => p2; set => p2 = value; }
        public Point P3 { get => p3; set => p3 = value; }
        public Color Color { get => color; set => color = value; }

        public override void Draw(Graphics g)
        {
            g.FillPolygon(new SolidBrush(color), new Point[] {p1, p2, p3 });
        }
    }
}
