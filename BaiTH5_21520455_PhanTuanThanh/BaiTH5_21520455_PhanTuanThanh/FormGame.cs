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
        List<Explode> bombs = new List<Explode>();
        // picJetAir is the player 
        int score = 0;
        bool lose = false;

        private void gameOver()
        {
            picJetAir.Visible = false;
            timerAppear.Stop();
            timerFall.Stop();
            timerMove.Stop();
            timerShooting.Stop();
            timerExplode.Stop();
            MessageBox.Show("Game over", "Notification",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }   

        private void ResetGame()
        {
            timerAppear.Start();
            timerFall.Start();
            timerMove.Start();
            timerExplode.Start();
            timerShooting.Start();
            stones.Clear();
            bullets.Clear();
            bombs.Clear();
            moveUp = false; moveDown = false; moveLeft = false; moveRight = false; lose = false;
            score = 0;
            picJetAir.Visible = true;
            picJetAir.Location = new Point(350, 850);
        }

        private void FormGame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Explode explode in bombs)
            {
                explode.Draw(g);
            }

            for (int i = 0; i < stones.Count; ++i)
            {
                Stone curStone = stones[i];
                curStone.Draw(g);
                
                for (int j = 0; j < bullets.Count; ++j)
                {
                    Bullet curBullet = bullets[j];
                    curBullet.Draw(g);
                    if (curBullet.ShootStone(curStone))
                    {
                        Explode bomb = new Explode(curStone.X - 30, curStone.Y - 30);
                        bombs.Add(bomb);
                        score += 10;
                        stones.Remove(curStone);
                        bullets.Remove(curBullet);
                    }
                }

                if (curStone.CollideJetair(picJetAir))
                { 
                    lose = true;
                    return;
                }
            }
        }

        private void createStone()
        {
            Random rnd = new Random();
            int MaxWidth = this.ClientSize.Width;
            int x = rnd.Next(MaxWidth - 50);
            stones.Add(new Stone(x, 0));
        }

        private void timerAppear_Tick(object sender, EventArgs e)
        {
            createStone();
        }

        private void timerFall_Tick(object sender, EventArgs e)
        {
            labelScore.Text = "Score: " + score.ToString();
               
            for (int i = 0; i < stones.Count; ++i)
            {
                Stone curStone = stones[i];
                if (curStone.Y >= this.ClientSize.Height - 100)
                    stones.Remove(curStone);
                else
                    curStone.Y += 5;
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

            if (lose)
            {
                gameOver();
                ResetGame();
                return;
            }
        }

        int imgWidth = 80, imgHeight = 80;
        int posX = 0, posY = 0;
        private bool moveUp = false, moveDown = false, moveLeft = false, moveRight = false;

        private void timerShooting_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < bullets.Count; ++i)
            {
                Bullet curBullet = bullets[i];
                if (curBullet.Y >= 0)
                    curBullet.Up();
                else
                    bullets.Remove(curBullet);
            }
        }

        private void timerExplode_Tick(object sender, EventArgs e)
        {
            bombs.Clear();      
        }

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
    }
}
