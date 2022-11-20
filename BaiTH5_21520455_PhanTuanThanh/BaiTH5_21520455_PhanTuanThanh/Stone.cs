using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTH5_21520455_PhanTuanThanh
{
    internal class Stone
    {
        private Bitmap bmp = new Bitmap("Meteorite.png");
        private int x, y;

        public Stone(int x, int y)
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

        public bool CollideJetair(PictureBox picJetAir)
        {
            bool res = false;

            int x1PT, x2PT, y1PT, y2PT;
            int x1TT, x2TT, y1TT, y2TT;

            x1PT = picJetAir.Location.X;
            x2PT = picJetAir.Location.X + picJetAir.Width;
            y1PT = picJetAir.Location.Y;
            y2PT = picJetAir.Location.Y + picJetAir.Height;

            x1TT = this.X;
            x2TT = this.X + this.bmp.Width;
            y1TT = this.Y;
            y2TT = this.Y + this.bmp.Height;
            if (x1PT < x2TT && x1TT < x2PT && y1PT < y2TT && y1TT < y2PT)
                res = true;

            return res;
        }
    }
}
