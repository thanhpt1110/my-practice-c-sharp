namespace BaiTap_GUI_1
{
    partial class FormFind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFind));
            this.labelFindMSSV = new System.Windows.Forms.Label();
            this.textBoxFindMSSV = new System.Windows.Forms.TextBox();
            this.ButtonBack = new System.Windows.Forms.Button();
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
            this.labelFindMSSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFindMSSV.AutoSize = true;
            this.labelFindMSSV.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFindMSSV.Location = new System.Drawing.Point(57, 60);
            this.labelFindMSSV.Name = "labelFindMSSV";
            this.labelFindMSSV.Size = new System.Drawing.Size(265, 33);
            this.labelFindMSSV.TabIndex = 0;
            this.labelFindMSSV.Text = "Nhập MSSV cần tìm: ";
            // 
            // textBoxFindMSSV
            // 
            this.textBoxFindMSSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFindMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFindMSSV.Location = new System.Drawing.Point(334, 60);
            this.textBoxFindMSSV.Multiline = true;
            this.textBoxFindMSSV.Name = "textBoxFindMSSV";
            this.textBoxFindMSSV.Size = new System.Drawing.Size(224, 31);
            this.textBoxFindMSSV.TabIndex = 1;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonBack.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBack.Location = new System.Drawing.Point(268, 386);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(161, 51);
            this.ButtonBack.TabIndex = 2;
            this.ButtonBack.Text = "Quay lại";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonFindMSSV
            // 
            this.ButtonFindMSSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonFindMSSV.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFindMSSV.Location = new System.Drawing.Point(591, 60);
            this.ButtonFindMSSV.Name = "ButtonFindMSSV";
            this.ButtonFindMSSV.Size = new System.Drawing.Size(75, 31);
            this.ButtonFindMSSV.TabIndex = 3;
            this.ButtonFindMSSV.Text = "Find";
            this.ButtonFindMSSV.UseVisualStyleBackColor = true;
            this.ButtonFindMSSV.Click += new System.EventHandler(this.ButtonFindMSSV_Click);
            // 
            // labelScore
            // 
            this.labelScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(154, 328);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(174, 25);
            this.labelScore.TabIndex = 16;
            this.labelScore.Text = "Điểm trung bình:";
            // 
            // labelClass
            // 
            this.labelClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(154, 265);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(53, 25);
            this.labelClass.TabIndex = 15;
            this.labelClass.Text = "Lớp:";
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(154, 202);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(81, 25);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Họ tên:";
            // 
            // labelMSSV
            // 
            this.labelMSSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMSSV.AutoSize = true;
            this.labelMSSV.BackColor = System.Drawing.SystemColors.Control;
            this.labelMSSV.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMSSV.Location = new System.Drawing.Point(154, 143);
            this.labelMSSV.Name = "labelMSSV";
            this.labelMSSV.Size = new System.Drawing.Size(72, 25);
            this.labelMSSV.TabIndex = 13;
            this.labelMSSV.Text = "MSSV:";
            // 
            // textBoxScore
            // 
            this.textBoxScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScore.Location = new System.Drawing.Point(381, 318);
            this.textBoxScore.Multiline = true;
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.ReadOnly = true;
            this.textBoxScore.Size = new System.Drawing.Size(212, 35);
            this.textBoxScore.TabIndex = 12;
            // 
            // textBoxClass
            // 
            this.textBoxClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClass.Location = new System.Drawing.Point(381, 255);
            this.textBoxClass.Multiline = true;
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.ReadOnly = true;
            this.textBoxClass.Size = new System.Drawing.Size(212, 35);
            this.textBoxClass.TabIndex = 11;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(381, 192);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxName.Size = new System.Drawing.Size(212, 35);
            this.textBoxName.TabIndex = 10;
            // 
            // textBoxMSSV
            // 
            this.textBoxMSSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMSSV.Location = new System.Drawing.Point(381, 133);
            this.textBoxMSSV.Multiline = true;
            this.textBoxMSSV.Name = "textBoxMSSV";
            this.textBoxMSSV.ReadOnly = true;
            this.textBoxMSSV.Size = new System.Drawing.Size(212, 35);
            this.textBoxMSSV.TabIndex = 9;
            // 
            // FormFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 472);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelMSSV);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.textBoxClass);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxMSSV);
            this.Controls.Add(this.ButtonFindMSSV);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.textBoxFindMSSV);
            this.Controls.Add(this.labelFindMSSV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormFind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFindMSSV;
        private System.Windows.Forms.TextBox textBoxFindMSSV;
        private System.Windows.Forms.Button ButtonBack;
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