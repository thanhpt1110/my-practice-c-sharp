namespace BaiLT_SQL_21520455_PhanTuanThanh
{
    partial class FormAdd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerNgVL = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNgSinh = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelNgayVaoLam = new System.Windows.Forms.Label();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.textBoxHoTen = new System.Windows.Forms.TextBox();
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.labelMSNV = new System.Windows.Forms.Label();
            this.textBoxMSNV = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelMSNV);
            this.panel1.Controls.Add(this.textBoxMSNV);
            this.panel1.Controls.Add(this.dateTimePickerNgVL);
            this.panel1.Controls.Add(this.dateTimePickerNgSinh);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.labelNgayVaoLam);
            this.panel1.Controls.Add(this.labelHoTen);
            this.panel1.Controls.Add(this.textBoxHoTen);
            this.panel1.Controls.Add(this.labelNgaySinh);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 478);
            this.panel1.TabIndex = 1;
            // 
            // dateTimePickerNgVL
            // 
            this.dateTimePickerNgVL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgVL.Location = new System.Drawing.Point(290, 286);
            this.dateTimePickerNgVL.Name = "dateTimePickerNgVL";
            this.dateTimePickerNgVL.Size = new System.Drawing.Size(214, 25);
            this.dateTimePickerNgVL.TabIndex = 12;
            // 
            // dateTimePickerNgSinh
            // 
            this.dateTimePickerNgSinh.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgSinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerNgSinh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgSinh.Location = new System.Drawing.Point(290, 212);
            this.dateTimePickerNgSinh.Name = "dateTimePickerNgSinh";
            this.dateTimePickerNgSinh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerNgSinh.Size = new System.Drawing.Size(215, 25);
            this.dateTimePickerNgSinh.TabIndex = 11;
            this.dateTimePickerNgSinh.Value = new System.DateTime(2022, 12, 2, 9, 38, 10, 0);
            // 
            // buttonSave
            // 
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Location = new System.Drawing.Point(290, 352);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(88, 29);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Lưu";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelNgayVaoLam
            // 
            this.labelNgayVaoLam.AutoSize = true;
            this.labelNgayVaoLam.Location = new System.Drawing.Point(162, 290);
            this.labelNgayVaoLam.Name = "labelNgayVaoLam";
            this.labelNgayVaoLam.Size = new System.Drawing.Size(109, 21);
            this.labelNgayVaoLam.TabIndex = 7;
            this.labelNgayVaoLam.Text = "Ngày vào làm:";
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Location = new System.Drawing.Point(212, 147);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(59, 21);
            this.labelHoTen.TabIndex = 5;
            this.labelHoTen.Text = "Họ tên:";
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.Location = new System.Drawing.Point(290, 139);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.Size = new System.Drawing.Size(214, 29);
            this.textBoxHoTen.TabIndex = 4;
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Location = new System.Drawing.Point(188, 216);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(83, 21);
            this.labelNgaySinh.TabIndex = 3;
            this.labelNgaySinh.Text = "Ngày sinh:";
            // 
            // labelMSNV
            // 
            this.labelMSNV.AutoSize = true;
            this.labelMSNV.Location = new System.Drawing.Point(190, 77);
            this.labelMSNV.Name = "labelMSNV";
            this.labelMSNV.Size = new System.Drawing.Size(81, 21);
            this.labelMSNV.TabIndex = 14;
            this.labelMSNV.Text = "Mã số NV:";
            // 
            // textBoxMSNV
            // 
            this.textBoxMSNV.Location = new System.Drawing.Point(290, 69);
            this.textBoxMSNV.Name = "textBoxMSNV";
            this.textBoxMSNV.Size = new System.Drawing.Size(215, 29);
            this.textBoxMSNV.TabIndex = 13;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 478);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAdd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgVL;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgSinh;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelNgayVaoLam;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.TextBox textBoxHoTen;
        private System.Windows.Forms.Label labelNgaySinh;
        private System.Windows.Forms.Label labelMSNV;
        private System.Windows.Forms.TextBox textBoxMSNV;
    }
}