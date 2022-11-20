using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace BaiTH5_21520455_PhanTuanThanh
{
    internal class Explode
    {
        private Bitmap bmp = new Bitmap("Explode.png");
        private int x, y;

        public Explode(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public Bitmap Bmp { get => bmp; set => bmp = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public void Draw(Graphics g)
        {
            g.DrawImage(bmp, new Point(x, y));
        }
    }
}
