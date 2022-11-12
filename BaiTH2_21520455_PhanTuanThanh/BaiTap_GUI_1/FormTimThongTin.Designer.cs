namespace BaiTap_GUI_1
{
    partial class FormTimThongTin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTimThongTin));
            this.labelFindMSSV = new System.Windows.Forms.Label();
            this.textBoxFindMSSV = new System.Windows.Forms.TextBox();
            this.ButtonFindMSSV = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMSSV = new System.Windows.Forms.Label();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMSSV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelFindMSSV
            // 
            this.labelFindMSSV.AutoSize = true;
            this.labelFindMSSV.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFindMSSV.Location = new System.Drawing.Point(110, 94);
            this.labelFindMSSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFindMSSV.Name = "labelFindMSSV";
            this.labelFindMSSV.Size = new System.Drawing.Size(265, 37);
            this.labelFindMSSV.TabIndex = 0;
            this.labelFindMSSV.Text = "Nhập MSSV cần tìm: ";
            // 
            // textBoxFindMSSV
            // 
            this.textBoxFindMSSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(224)))), ((int)(((byte)(226)))));
            this.textBoxFindMSSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFindMSSV.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFindMSSV.Location = new System.Drawing.Point(387, 99);
            this.textBoxFindMSSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFindMSSV.Multiline = true;
            this.textBoxFindMSSV.Name = "textBoxFindMSSV";
            this.textBoxFindMSSV.Size = new System.Drawing.Size(270, 33);
            this.textBoxFindMSSV.TabIndex = 1;
            // 
            // ButtonFindMSSV
            // 
            this.ButtonFindMSSV.FlatAppearance.BorderSize = 0;
            this.ButtonFindMSSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFindMSSV.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFindMSSV.Image = ((System.Drawing.Image)(resources.GetObject("ButtonFindMSSV.Image")));
            this.ButtonFindMSSV.Location = new System.Drawing.Point(665, 100);
            this.ButtonFindMSSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonFindMSSV.Name = "ButtonFindMSSV";
            this.ButtonFindMSSV.Size = new System.Drawing.Size(51, 33);
            this.ButtonFindMSSV.TabIndex = 3;
            this.ButtonFindMSSV.UseVisualStyleBackColor = true;
            this.ButtonFindMSSV.Click += new System.EventHandler(this.ButtonFindMSSV_Click);
            // 
            // labelScore
            // 
            this.labelScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(205, 378);
            this.labelScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(170, 30);
            this.labelScore.TabIndex = 16;
            this.labelScore.Text = "Điểm trung bình:";
            // 
            // labelClass
            // 
            this.labelClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(206, 311);
            this.labelClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(53, 30);
            this.labelClass.TabIndex = 15;
            this.labelClass.Text = "Lớp:";
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(205, 246);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(81, 30);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Họ tên:";
            // 
            // labelMSSV
            // 
            this.labelMSSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMSSV.AutoSize = true;
            this.labelMSSV.BackColor = System.Drawing.Color.Transparent;
            this.labelMSSV.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMSSV.Location = new System.Drawing.Point(205, 181);
            this.labelMSSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMSSV.Name = "labelMSSV";
            this.labelMSSV.Size = new System.Drawing.Size(72, 30);
            this.labelMSSV.TabIndex = 13;
            this.labelMSSV.Text = "MSSV:";
            // 
            // textBoxScore
            // 
            this.textBoxScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(197)))), ((int)(((byte)(200)))));
            this.textBoxScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxScore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScore.Location = new System.Drawing.Point(386, 370);
            this.textBoxScore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxScore.Multiline = true;
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.ReadOnly = true;
            this.textBoxScore.Size = new System.Drawing.Size(271, 38);
            this.textBoxScore.TabIndex = 12;
            // 
            // textBoxClass
            // 
            this.textBoxClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(197)))), ((int)(((byte)(200)))));
            this.textBoxClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxClass.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClass.Location = new System.Drawing.Point(386, 305);
            this.textBoxClass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxClass.Multiline = true;
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.ReadOnly = true;
            this.textBoxClass.Size = new System.Drawing.Size(271, 36);
            this.textBoxClass.TabIndex = 11;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(197)))), ((int)(((byte)(200)))));
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(386, 240);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(271, 36);
            this.textBoxName.TabIndex = 10;
            // 
            // textBoxMSSV
            // 
            this.textBoxMSSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMSSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(197)))), ((int)(((byte)(200)))));
            this.textBoxMSSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMSSV.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMSSV.Location = new System.Drawing.Point(387, 175);
            this.textBoxMSSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMSSV.Multiline = true;
            this.textBoxMSSV.Name = "textBoxMSSV";
            this.textBoxMSSV.ReadOnly = true;
            this.textBoxMSSV.Size = new System.Drawing.Size(270, 36);
            this.textBoxMSSV.TabIndex = 9;
            // 
            // FormTimThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(197)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(861, 558);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelMSSV);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.textBoxClass);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxMSSV);
            this.Controls.Add(this.ButtonFindMSSV);
            this.Controls.Add(this.textBoxFindMSSV);
            this.Controls.Add(this.labelFindMSSV);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormTimThongTin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Info";
            this.Load += new System.EventHandler(this.FormTimThongTin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFindMSSV;
        private System.Windows.Forms.TextBox textBoxFindMSSV;
        private System.Windows.Forms.Button ButtonFindMSSV;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMSSV;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxMSSV;
    }
}