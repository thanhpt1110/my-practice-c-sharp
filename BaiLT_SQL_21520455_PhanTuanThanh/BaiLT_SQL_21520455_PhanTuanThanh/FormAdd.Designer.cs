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
            this.labelMSNV = new System.Windows.Forms.Label();
            this.textBoxMSNV = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgVL = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNgSinh = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelNgayVaoLam = new System.Windows.Forms.Label();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.textBoxHoTen = new System.Windows.Forms.TextBox();
            this.labelNgaySinh = new System.Windows.Forms.Label();
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
            // labelMSNV
            // 
            this.labelMSNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMSNV.AutoSize = true;
            this.labelMSNV.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMSNV.Location = new System.Drawing.Point(190, 77);
            this.labelMSNV.Name = "labelMSNV";
            this.labelMSNV.Size = new System.Drawing.Size(98, 25);
            this.labelMSNV.TabIndex = 14;
            this.labelMSNV.Text = "Mã số NV:";
            // 
            // textBoxMSNV
            // 
            this.textBoxMSNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMSNV.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMSNV.Location = new System.Drawing.Point(300, 69);
            this.textBoxMSNV.Name = "textBoxMSNV";
            this.textBoxMSNV.Size = new System.Drawing.Size(215, 33);
            this.textBoxMSNV.TabIndex = 13;
            // 
            // dateTimePickerNgVL
            // 
            this.dateTimePickerNgVL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerNgVL.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgVL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgVL.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgVL.Location = new System.Drawing.Point(300, 282);
            this.dateTimePickerNgVL.Name = "dateTimePickerNgVL";
            this.dateTimePickerNgVL.Size = new System.Drawing.Size(150, 33);
            this.dateTimePickerNgVL.TabIndex = 12;
            // 
            // dateTimePickerNgSinh
            // 
            this.dateTimePickerNgSinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerNgSinh.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgSinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerNgSinh.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgSinh.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgSinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgSinh.Location = new System.Drawing.Point(300, 208);
            this.dateTimePickerNgSinh.Name = "dateTimePickerNgSinh";
            this.dateTimePickerNgSinh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerNgSinh.Size = new System.Drawing.Size(150, 33);
            this.dateTimePickerNgSinh.TabIndex = 11;
            this.dateTimePickerNgSinh.Value = new System.DateTime(2022, 12, 2, 9, 38, 10, 0);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(300, 366);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(106, 44);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Lưu";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelNgayVaoLam
            // 
            this.labelNgayVaoLam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNgayVaoLam.AutoSize = true;
            this.labelNgayVaoLam.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayVaoLam.Location = new System.Drawing.Point(162, 290);
            this.labelNgayVaoLam.Name = "labelNgayVaoLam";
            this.labelNgayVaoLam.Size = new System.Drawing.Size(131, 25);
            this.labelNgayVaoLam.TabIndex = 7;
            this.labelNgayVaoLam.Text = "Ngày vào làm:";
            // 
            // labelHoTen
            // 
            this.labelHoTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoTen.Location = new System.Drawing.Point(212, 147);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(72, 25);
            this.labelHoTen.TabIndex = 5;
            this.labelHoTen.Text = "Họ tên:";
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxHoTen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHoTen.Location = new System.Drawing.Point(300, 139);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.Size = new System.Drawing.Size(214, 33);
            this.textBoxHoTen.TabIndex = 4;
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgaySinh.Location = new System.Drawing.Point(188, 216);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(100, 25);
            this.labelNgaySinh.TabIndex = 3;
            this.labelNgaySinh.Text = "Ngày sinh:";
            // 
            // FormAdd
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 478);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAdd";
            this.Load += new System.EventHandler(this.FormAdd_Load);
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