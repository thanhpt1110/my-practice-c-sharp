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
        List<Bullet> bullets = new List<Bullet>();
        // picJetAir is the player 

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
            foreach (Bullet bullet in bullets)
                bullet.Draw(g);
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
                    stones.Remove(stones[i]);
                else
                    stones[i].Y += 5;
            }
            for (int i = 0; i < bullets.Count; ++i)
            {
                if (bullets[i].Y >= 10)
                    bullets[i].Up();
                else
                    bullets.Remove(bullets[i]);
            }
            this.Refresh();
        }

        private void timerMove_Tick(object sender, EventArgs e)
        {
            if (moveLeft == true && picJetAir.Left > 0)
                this.picJetAir.Left -= 10;
            if (moveRight == true && picJetAir.Right < this.ClientSize.Width)
                this.picJetAir.Left += 10;
            if (moveUp == true && picJetAir.Top > 0)
                this.picJetAir.Top -= 10;
            if (moveDown == true && picJetAir.Top < this.ClientSize.Height - imgHeight)
                this.picJetAir.Top += 10;
            this.Refresh();
        }

        int imgWidth = 80, imgHeight = 80;
        int posX = 0, posY = 0;
        private bool moveUp = false, moveDown = false, moveLeft = false, moveRight = false;
        
        private void keyisdown(object sender, KeyEventArgs e)
        {
            posX = this.picJetAir.Location.X;
            posY = this.picJetAir.Location.Y;

            if (e.KeyCode == Keys.Left)
                moveLeft = true;
            if (e.KeyCode == Keys.Right)
                moveRight = true;
            if (e.KeyCode == Keys.Up)
                moveUp = true;
            if (e.KeyCode == Keys.Down)
                moveDown = true;
            if (e.KeyCode == Keys.Space)
                bullets.Add(new Bullet(posX + imgWidth / 2 - 15, posY));
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

        private void checkLoseGame()
        {
            foreach(Stone stone in stones)
            {
                if (stone.Y == picJetAir.Location.Y)
                {
                    MessageBox.Show("Game over");
                    this.Close();
                }
            }
        }
    }
}
