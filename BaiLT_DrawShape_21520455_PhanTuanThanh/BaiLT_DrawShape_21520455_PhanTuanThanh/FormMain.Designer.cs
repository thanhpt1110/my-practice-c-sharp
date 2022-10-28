namespace BaiLT_DrawShape_21520455_PhanTuanThanh
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelChooseShape = new System.Windows.Forms.FlowLayoutPanel();
            this.labelChooseShape = new System.Windows.Forms.Label();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.flowLayoutPanelChooseColor = new System.Windows.Forms.FlowLayoutPanel();
            this.labelChooseColor = new System.Windows.Forms.Label();
            this.buttonColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.flowLayoutPanelDraw = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanelChooseShape.SuspendLayout();
            this.flowLayoutPanelChooseColor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanelChooseShape);
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanelChooseColor);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanelDraw);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 621);
            this.splitContainer1.SplitterDistance = 402;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // flowLayoutPanelChooseShape
            // 
            this.flowLayoutPanelChooseShape.AutoScroll = true;
            this.flowLayoutPanelChooseShape.Controls.Add(this.labelChooseShape);
            this.flowLayoutPanelChooseShape.Controls.Add(this.buttonRectangle);
            this.flowLayoutPanelChooseShape.Controls.Add(this.buttonTriangle);
            this.flowLayoutPanelChooseShape.Controls.Add(this.buttonCircle);
            this.flowLayoutPanelChooseShape.Controls.Add(this.buttonLine);
            this.flowLayoutPanelChooseShape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelChooseShape.Location = new System.Drawing.Point(0, 106);
            this.flowLayoutPanelChooseShape.Name = "flowLayoutPanelChooseShape";
            this.flowLayoutPanelChooseShape.Padding = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.flowLayoutPanelChooseShape.Size = new System.Drawing.Size(400, 513);
            this.flowLayoutPanelChooseShape.TabIndex = 7;
            // 
            // labelChooseShape
            // 
            this.labelChooseShape.AutoSize = true;
            this.labelChooseShape.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.labelChooseShape.Location = new System.Drawing.Point(13, 20);
            this.labelChooseShape.Name = "labelChooseShape";
            this.labelChooseShape.Padding = new System.Windows.Forms.Padding(5, 0, 0, 20);
            this.labelChooseShape.Size = new System.Drawing.Size(261, 57);
            this.labelChooseShape.TabIndex = 5;
            this.labelChooseShape.Text = "Choose your shape: ";
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.BackColor = System.Drawing.Color.Transparent;
            this.buttonRectangle.FlatAppearance.BorderSize = 0;
            this.buttonRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRectangle.Image = ((System.Drawing.Image)(resources.GetObject("buttonRectangle.Image")));
            this.buttonRectangle.Location = new System.Drawing.Point(13, 80);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(161, 95);
            this.buttonRectangle.TabIndex = 6;
            this.buttonRectangle.UseVisualStyleBackColor = false;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // buttonTriangle
            // 
            this.buttonTriangle.BackColor = System.Drawing.Color.Transparent;
            this.buttonTriangle.FlatAppearance.BorderSize = 0;
            this.buttonTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTriangle.Image = ((System.Drawing.Image)(resources.GetObject("buttonTriangle.Image")));
            this.buttonTriangle.Location = new System.Drawing.Point(180, 80);
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.Size = new System.Drawing.Size(173, 142);
            this.buttonTriangle.TabIndex = 7;
            this.buttonTriangle.UseVisualStyleBackColor = false;
            this.buttonTriangle.Click += new System.EventHandler(this.buttonTriangle_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.BackColor = System.Drawing.Color.Transparent;
            this.buttonCircle.FlatAppearance.BorderSize = 0;
            this.buttonCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCircle.Image = ((System.Drawing.Image)(resources.GetObject("buttonCircle.Image")));
            this.buttonCircle.Location = new System.Drawing.Point(13, 228);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(161, 166);
            this.buttonCircle.TabIndex = 8;
            this.buttonCircle.UseVisualStyleBackColor = false;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.BackColor = System.Drawing.Color.Transparent;
            this.buttonLine.FlatAppearance.BorderSize = 0;
            this.buttonLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLine.Image = ((System.Drawing.Image)(resources.GetObject("buttonLine.Image")));
            this.buttonLine.Location = new System.Drawing.Point(180, 228);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonLine.Size = new System.Drawing.Size(173, 175);
            this.buttonLine.TabIndex = 9;
            this.buttonLine.UseVisualStyleBackColor = false;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // flowLayoutPanelChooseColor
            // 
            this.flowLayoutPanelChooseColor.BackColor = System.Drawing.Color.MistyRose;
            this.flowLayoutPanelChooseColor.Controls.Add(this.labelChooseColor);
            this.flowLayoutPanelChooseColor.Controls.Add(this.buttonColor);
            this.flowLayoutPanelChooseColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelChooseColor.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelChooseColor.Name = "flowLayoutPanelChooseColor";
            this.flowLayoutPanelChooseColor.Padding = new System.Windows.Forms.Padding(17, 35, 0, 0);
            this.flowLayoutPanelChooseColor.Size = new System.Drawing.Size(400, 106);
            this.flowLayoutPanelChooseColor.TabIndex = 6;
            // 
            // labelChooseColor
            // 
            this.labelChooseColor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelChooseColor.AutoSize = true;
            this.labelChooseColor.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.labelChooseColor.Location = new System.Drawing.Point(20, 37);
            this.labelChooseColor.Name = "labelChooseColor";
            this.labelChooseColor.Size = new System.Drawing.Size(102, 37);
            this.labelChooseColor.TabIndex = 2;
            this.labelChooseColor.Text = "Color : ";
            // 
            // buttonColor
            // 
            this.buttonColor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonColor.BackColor = System.Drawing.Color.Black;
            this.buttonColor.Location = new System.Drawing.Point(128, 38);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(101, 35);
            this.buttonColor.TabIndex = 3;
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click_1);
            // 
            // flowLayoutPanelDraw
            // 
            this.flowLayoutPanelDraw.BackColor = System.Drawing.Color.LightGray;
            this.flowLayoutPanelDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelDraw.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelDraw.Name = "flowLayoutPanelDraw";
            this.flowLayoutPanelDraw.Size = new System.Drawing.Size(774, 619);
            this.flowLayoutPanelDraw.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 106);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label1.Location = new System.Drawing.Point(218, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your shapes will be drawn here";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 621);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drawing";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanelChooseShape.ResumeLayout(false);
            this.flowLayoutPanelChooseShape.PerformLayout();
            this.flowLayoutPanelChooseColor.ResumeLayout(false);
            this.flowLayoutPanelChooseColor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label labelChooseShape;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChooseShape;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChooseColor;
        private System.Windows.Forms.Label labelChooseColor;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Button buttonTriangle;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDraw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

