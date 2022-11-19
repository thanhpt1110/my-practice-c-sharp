using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiLT_FallingBall_21520455_PhanTuanThanh
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.labelInstruction.Visible = true;
            timer2.Stop();
        }

        protected int x = 0;
        protected int y = 0;

        private void FormMain_MouseClick_1(object sender, MouseEventArgs e)
        {
            timer2.Start();
            x = e.Location.X - 25;
            y = e.Location.Y - 25;
            int rad = 50;
            Random rnd = new Random();
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            balls.Add(new Ball(x, y, rad, randomColor, true));
        }

        List<Ball> balls = new List<Ball>();
        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Ball ball in balls)
                ball.Draw(g);
        }

        /*1: Down
        2: Up
        3: Left
        4: Right
        5: Up + Right
        6: Up + Left
        7: Down + Right 
        8: Down + Left
        => 	
        Cạnh dưới cùng: sẽ đc đi các hướng 2, 5, 6 
        Cạnh trên cùng: sẽ đc đi các hướng 1, 7, 8 
        Cạnh bên trái: _____ 4, 5, 7
        Cạnh bên phải: _____ 3, 6, 8*/

        int[] topEdge = new int[3] { 1, 7, 8 };
        int[] botEdge = new int[3] { 2, 5, 6 };
        int[] leftEdge = new int[3] { 4, 5, 7 };
        int[] rightEdge = new int[3] { 3, 6, 8 };

        private void timer1_Tick(object sender, EventArgs e)
        {
            int MaxWidth = this.ClientSize.Width;
            int MaxHeight = this.ClientSize.Height;

            foreach (Ball ball in balls)
            {
                // Update Coordinate
                switch (ball.Type)
                {
                    case 1:
                        ball.Down();
                        ball.Down1 = true;
                        ball.Right1 = false;
                        break;
                    case 2:
                        ball.Up();
                        ball.Down1 = false;
                        ball.Right1 = false;
                        break;  
                    case 3:
                        ball.Left();
                        ball.Down1 = false;
                        ball.Right1 = false;
                        break;
                    case 4:
                        ball.Right();
                        ball.Down1 = false;
                        ball.Right1 = true;
                        break;
                    case 5:
                        ball.Right();
                        ball.Up();
                        ball.Down1 = false;
                        ball.Right1 = true;
                        break;
                    case 6:
                        ball.Left();
                        ball.Up();
                        ball.Down1 = false;
                        ball.Right1 = false;
                        break;
                    case 7:
                        ball.Right();
                        ball.Down();
                        ball.Down1 = true;
                        ball.Right1 = true;
                        break;
                    case 8:
                        ball.Left();
                        ball.Down();
                        ball.Down1 = true;
                        ball.Right1 = false;
                        break;
                    default:
                        break;
                }

                Random rnd = new Random();    
                int idx = rnd.Next(0, 3);

                if (ball.Y >= MaxHeight - 55)
                    ball.Type = botEdge[idx];
                else if (ball.Y <= 0)
                    ball.Type = topEdge[idx];
                else if (ball.X <= 0)
                    ball.Type= leftEdge[idx];
                else if (ball.X >= MaxWidth - 55)
                    ball.Type = rightEdge[idx];

            }
            this.Invalidate();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.labelInstruction.Visible = false;
            timer2.Stop();
        }
    }
}
