namespace BaiTap_GUI_1
{
    partial class FormXoaSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormXoaSV));
            this.ButtonXoaMSSV = new System.Windows.Forms.Button();
            this.textBoxXoaMSSV = new System.Windows.Forms.TextBox();
            this.labelXoaMSSV = new System.Windows.Forms.Label();
            this.labelXoaThanhCong = new System.Windows.Forms.Label();
            this.labelXoaThatBai = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonXoaMSSV
            // 
            this.ButtonXoaMSSV.FlatAppearance.BorderSize = 0;
            this.ButtonXoaMSSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonXoaMSSV.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonXoaMSSV.Image = ((System.Drawing.Image)(resources.GetObject("ButtonXoaMSSV.Image")));
            this.ButtonXoaMSSV.Location = new System.Drawing.Point(629, 126);
            this.ButtonXoaMSSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonXoaMSSV.Name = "ButtonXoaMSSV";
            this.ButtonXoaMSSV.Size = new System.Drawing.Size(42, 44);
            this.ButtonXoaMSSV.TabIndex = 6;
            this.ButtonXoaMSSV.UseVisualStyleBackColor = true;
            this.ButtonXoaMSSV.Click += new System.EventHandler(this.ButtonXoaMSSV_Click);
            // 
            // textBoxXoaMSSV
            // 
            this.textBoxXoaMSSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(224)))), ((int)(((byte)(226)))));
            this.textBoxXoaMSSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxXoaMSSV.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxXoaMSSV.Location = new System.Drawing.Point(396, 131);
            this.textBoxXoaMSSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxXoaMSSV.Multiline = true;
            this.textBoxXoaMSSV.Name = "textBoxXoaMSSV";
            this.textBoxXoaMSSV.Size = new System.Drawing.Size(225, 33);
            this.textBoxXoaMSSV.TabIndex = 5;
            // 
            // labelXoaMSSV
            // 
            this.labelXoaMSSV.AutoSize = true;
            this.labelXoaMSSV.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXoaMSSV.Location = new System.Drawing.Point(129, 127);
            this.labelXoaMSSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelXoaMSSV.Name = "labelXoaMSSV";
            this.labelXoaMSSV.Size = new System.Drawing.Size(268, 37);
            this.labelXoaMSSV.TabIndex = 4;
            this.labelXoaMSSV.Text = "Nhập MSSV cần xóa: ";
            // 
            // labelXoaThanhCong
            // 
            this.labelXoaThanhCong.AutoSize = true;
            this.labelXoaThanhCong.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXoaThanhCong.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelXoaThanhCong.Location = new System.Drawing.Point(292, 216);
            this.labelXoaThanhCong.Name = "labelXoaThanhCong";
            this.labelXoaThanhCong.Size = new System.Drawing.Size(271, 30);
            this.labelXoaThanhCong.TabIndex = 7;
            this.labelXoaThanhCong.Text = "Xóa sinh viên thành công!";
            // 
            // labelXoaThatBai
            // 
            this.labelXoaThatBai.AutoSize = true;
            this.labelXoaThatBai.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXoaThatBai.ForeColor = System.Drawing.Color.DarkRed;
            this.labelXoaThatBai.Location = new System.Drawing.Point(292, 216);
            this.labelXoaThatBai.Name = "labelXoaThatBai";
            this.labelXoaThatBai.Size = new System.Drawing.Size(262, 30);
            this.labelXoaThatBai.TabIndex = 8;
            this.labelXoaThatBai.Text = "Không tồn tại MSSV này!";
            // 
            // FormXoaSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(197)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(861, 558);
            this.Controls.Add(this.labelXoaThatBai);
            this.Controls.Add(this.labelXoaThanhCong);
            this.Controls.Add(this.ButtonXoaMSSV);
            this.Controls.Add(this.textBoxXoaMSSV);
            this.Controls.Add(this.labelXoaMSSV);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormXoaSV";
            this.Text = "FormXoaSV";
            this.Load += new System.EventHandler(this.FormXoaSV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonXoaMSSV;
        private System.Windows.Forms.TextBox textBoxXoaMSSV;
        private System.Windows.Forms.Label labelXoaMSSV;
        private System.Windows.Forms.Label labelXoaThanhCong;
        private System.Windows.Forms.Label labelXoaThatBai;
    }
}