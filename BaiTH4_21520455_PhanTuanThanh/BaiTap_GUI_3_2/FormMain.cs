using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_GUI_3_2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        protected int x = 0;
        protected int y = 0;

        private void FormMain_MouseClick_1(object sender, MouseEventArgs e)
        {
            x = e.Location.X - 25;
            y = e.Location.Y - 25;
            int rad = 50;
            Random rnd = new Random();
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            balls.Add(new Ball(x, y, rad, randomColor));
        }

        List<Ball> balls = new List<Ball>();
        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Ball ball in balls)
                ball.Draw(g);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int MaxWidth = this.ClientSize.Width;
            int MaxHeight = this.ClientSize.Height;
            for (int i = 0; i < balls.Count; ++i)
            {
                if (balls[i].Y < MaxHeight - 55)
                    balls[i].Down();
                else
                    balls.Remove(balls[i]);
            }
            this.Invalidate();
        }
    }

    class Ball
    {
        private int x, y, rad, type;
        private Color color;

        public Ball(int x, int y, int rad, Color color)
        {
            this.X = x;
            this.Y = y;
            this.Rad = rad;
            this.Color = color;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Rad { get => rad; set => rad = value; }
        public int Type { get => type; set => type = value; }
        public Color Color { get => color; set => color = value; }

        public void Draw(Graphics g)
        {
            g.FillEllipse(new SolidBrush(this.Color), X, Y, Rad, Rad);
        }

        public void Down()
        {
            this.Y += 5;
        }
    }
}
