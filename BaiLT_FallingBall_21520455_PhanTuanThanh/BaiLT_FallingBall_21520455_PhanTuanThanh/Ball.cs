using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiLT_FallingBall_21520455_PhanTuanThanh
{
    internal class Ball
    {
        private int x, y, rad, type = 1;
        private Color color;
        private bool down, right;

        public Ball(int x, int y, int rad, Color color, bool down)
        {
            this.X = x;
            this.Y = y;
            this.Rad = rad;
            this.Color = color;
            this.Down1 = down;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Rad { get => rad; set => rad = value; }
        public int Type { get => type; set => type = value; }
        public Color Color { get => color; set => color = value; }
        public bool Down1 { get => down; set => down = value; }
        public bool Right1 { get => right; set => right = value; }

        public void Draw(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.FillEllipse(new SolidBrush(this.Color), X, Y, Rad, Rad);
        }

        public int getType(int a, int b)
        {
            Random rnd = new Random();
            int x = rnd.Next(a, b);
            return x;
        }

        public void Up()
        {
            this.Y -= 5;
        }

        public void Down()
        {
            this.Y += 5;
        }

        public void Left()
        {
            this.X -= 5;
        }

        public void Right()
        {
            this.X += 5;
        }
    }
}
