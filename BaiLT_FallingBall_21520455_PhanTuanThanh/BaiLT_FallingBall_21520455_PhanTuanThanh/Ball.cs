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
        private int x, y, rad = 50, type = 1;
        private Color color;
       
        public Ball(int x, int y, Color color)
        {
            this.X = x;
            this.Y = y;
            this.Color = color;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Rad { get => rad; set => rad = value; }
        public int Type { get => type; set => type = value; }
        public Color Color { get => color; set => color = value; }

        public void Draw(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.FillEllipse(new SolidBrush(this.Color), X, Y, Rad, Rad);
        }

        public void MoveUp()
        {
            this.Y -= 5;
        }

        public void MoveDown()
        {
            this.Y += 5;
        }

        public void MoveLeft()
        {
            this.X -= 5;
        }

        public void MoveRight()
        {
            this.X += 5;
        }

        /*
        1: Down
        2: Up
        3: Left
        4: Right
        5: Up + Right
        6: Up + Left
        7: Down + Right 
        8: Down + Left
        => 	
        Bottom edge can go these directions: 2, 5, 6 
        Top edge _____: 1, 7, 8 
        Left edge _____: 4, 5, 7
        Right edge _____: 3, 6, 8
        */

        public void UpdateCoordinate()
        {
            switch (this.Type)
            {
                case 1:
                    this.MoveDown();
                    break;
                case 2:
                    this.MoveUp();
                    break;
                case 3:
                    this.MoveLeft();
                    break;
                case 4:
                    this.MoveRight();
                    break;
                case 5:
                    this.MoveRight();
                    this.MoveUp();
                    break;
                case 6:
                    this.MoveLeft();
                    this.MoveUp();
                    break;
                case 7:
                    this.MoveRight();
                    this.MoveDown();
                    break;
                case 8:
                    this.MoveLeft();
                    this.MoveDown();
                    break;
                default:
                    break;
            }
        }

        private int[] topEdge = new int[3] { 1, 7, 8 };
        private int[] botEdge = new int[3] { 2, 5, 6 };
        private int[] leftEdge = new int[3] { 4, 5, 7 };
        private int[] rightEdge = new int[3] { 3, 6, 8 };

        public void CheckDirection(int MaxWidth, int MaxHeight)
        {
            Random rnd = new Random();
            int idx = rnd.Next(0, 3);

            if (this.Y >= MaxHeight - 55)
                this.Type = botEdge[idx];
            else if (this.Y <= 0)
                this.Type = topEdge[idx];
            else if (this.X <= 0)
                this.Type = leftEdge[idx];
            else if (this.X >= MaxWidth - 55)
                this.Type = rightEdge[idx];
        }
    }
}
