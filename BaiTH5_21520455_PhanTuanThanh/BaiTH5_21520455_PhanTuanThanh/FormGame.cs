using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTH5_21520455_PhanTuanThanh
{
    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();
        }

        List<Stone> stones = new List<Stone>();
        private void createStone()
        {
            Random rnd = new Random();
            int MaxWidth = this.ClientSize.Width;
            int x = rnd.Next(MaxWidth - 50);
            stones.Add(new Stone(x, 0));
        }

        private void FormGame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Stone stone in stones)
                stone.Draw(g);
        }

        private void timerAppear_Tick(object sender, EventArgs e)
        {
            createStone();
        }

        private void timerFall_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < stones.Count; ++i)
            {
                if (stones[i].Y >= this.ClientSize.Height - 100)
                {
                    stones.RemoveAt(i);
                    --i;
                }
                else
                    stones[i].Y += 5;
            }
            this.Invalidate();
        }

        private bool moveLeft = false, moveRight = false, moveUp = false, moveDown = false;
        private void timerMove_Tick(object sender, EventArgs e)
        {
            if (moveLeft == true && picJetAir.Left > 0)
                this.picJetAir.Left -= 5;
            if (moveRight == true && picJetAir.Right < this.ClientSize.Width)
                this.picJetAir.Left += 5;
            if (moveLeft == true && picJetAir.Left > 0)
                this.picJetAir.Left -= 5;
            if (moveLeft == true && picJetAir.Left > 0)
                this.picJetAir.Left -= 5;
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                moveLeft = true;
            if (e.KeyCode == Keys.Right)
                moveRight = true;
            if (e.KeyCode == Keys.Up)
                moveUp = true;
            if (e.KeyCode == Keys.Down)
                moveDown = true;
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                moveLeft = false;
            if (e.KeyCode == Keys.Right)
                moveRight = false;
            if (e.KeyCode == Keys.Up)
                moveUp = false;
            if (e.KeyCode == Keys.Down)
                moveDown = false;
        }
    }

    class Stone
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
    }

    class JetAir
    {
        private Bitmap bmp = new Bitmap("jetair");
        private int x, y;

        public JetAir(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public Bitmap Bmp { get => bmp; set => bmp = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }
}
