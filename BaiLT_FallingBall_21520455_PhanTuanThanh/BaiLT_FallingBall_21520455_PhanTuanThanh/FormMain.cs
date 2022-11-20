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
            SetDefaultValue();  
        }

        private void SetDefaultValue()
        {
            timer2.Stop();
        }

        // Declare variables
        private List<Ball> balls = new List<Ball>();
        private int PosX = 0, PosY = 0;

        private void FormMain_MouseClick_1(object sender, MouseEventArgs e)
        {
            timer2.Start();
            PosX = e.Location.X - 25;
            PosY = e.Location.Y - 25;

            Random rnd = new Random();
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            balls.Add(new Ball(PosX, PosY, randomColor));
        }

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

            foreach (Ball ball in balls)
            {
                ball.UpdateCoordinate();
                ball.CheckDirection(MaxWidth, MaxHeight);
            }

            this.Refresh(); 
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.labelInstruction.Visible = false;
            this.labelInstruction.Enabled = false;
            timer2.Stop();
            timer2.Enabled = false;
        }
    }
}
