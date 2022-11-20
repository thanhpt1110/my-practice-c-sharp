using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace BaiTH5_21520455_PhanTuanThanh
{
    internal class Bullet
    {
        private Bitmap bmp = new Bitmap("Bullet.png");
        private int x, y;


        public Bullet(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Up()
        {
            this.Y -= 10;
        }   

        public bool ShootStone(Stone stone)
        {
            bool res = false;
            int stoneX = stone.X, stoneY = stone.Y;
            int stoneHeight = stone.Bmp.Height, stoneWidth = stone.Bmp.Width;

            if (stoneY + stoneHeight >= this.Y && stoneY <= this.Y && 
                stoneX - 10 <= this.X && this.X + 5 <= stoneX + stoneWidth + 50)
                res = true;
            return res;
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(bmp, new Point(x, y));
        }

        public Bitmap Bmp { get => bmp; set => bmp = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }
}
