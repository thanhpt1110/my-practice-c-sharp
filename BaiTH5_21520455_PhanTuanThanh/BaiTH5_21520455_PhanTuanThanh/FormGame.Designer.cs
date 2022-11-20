namespace BaiTH5_21520455_PhanTuanThanh
{
    partial class FormGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.timerAppear = new System.Windows.Forms.Timer(this.components);
            this.timerFall = new System.Windows.Forms.Timer(this.components);
            this.picJetAir = new System.Windows.Forms.PictureBox();
            this.timerMove = new System.Windows.Forms.Timer(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            this.timerExplode = new System.Windows.Forms.Timer(this.components);
            this.timerShooting = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picJetAir)).BeginInit();
            this.SuspendLayout();
            // 
            // timerAppear
            // 
            this.timerAppear.Enabled = true;
            this.timerAppear.Interval = 1000;
            this.timerAppear.Tick += new System.EventHandler(this.timerAppear_Tick);
            // 
            // timerFall
            // 
            this.timerFall.Enabled = true;
            this.timerFall.Interval = 50;
            this.timerFall.Tick += new System.EventHandler(this.timerFall_Tick);
            // 
            // picJetAir
            // 
            this.picJetAir.BackColor = System.Drawing.Color.Transparent;
            this.picJetAir.Image = ((System.Drawing.Image)(resources.GetObject("picJetAir.Image")));
            this.picJetAir.Location = new System.Drawing.Point(350, 850);
            this.picJetAir.Name = "picJetAir";
            this.picJetAir.Size = new System.Drawing.Size(80, 80);
            this.picJetAir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJetAir.TabIndex = 0;
            this.picJetAir.TabStop = false;
            // 
            // timerMove
            // 
            this.timerMove.Enabled = true;
            this.timerMove.Interval = 10;
            this.timerMove.Tick += new System.EventHandler(this.timerMove_Tick);
            // 
            // labelScore
            // 
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelScore.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.Yellow;
            this.labelScore.Location = new System.Drawing.Point(25, 30);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(190, 50);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Score: ";
            // 
            // timerExplode
            // 
            this.timerExplode.Enabled = true;
            this.timerExplode.Interval = 500;
            this.timerExplode.Tick += new System.EventHandler(this.timerExplode_Tick);
            // 
            // timerShooting
            // 
            this.timerShooting.Enabled = true;
            this.timerShooting.Interval = 20;
            this.timerShooting.Tick += new System.EventHandler(this.timerShooting_Tick);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 961);
            this.Controls.Add(this.picJetAir);
            this.Controls.Add(this.labelScore);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 1000);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Fighter";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormGame_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.picJetAir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerAppear;
        private System.Windows.Forms.Timer timerFall;
        private System.Windows.Forms.PictureBox picJetAir;
        private System.Windows.Forms.Timer timerMove;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer timerExplode;
        private System.Windows.Forms.Timer timerShooting;
    }
}

