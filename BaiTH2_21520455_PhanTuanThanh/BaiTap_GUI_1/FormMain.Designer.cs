namespace BaiTap_GUI_1
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
            this.panelName = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonSuaThongTin = new System.Windows.Forms.Button();
            this.buttonXoaSinhVien = new System.Windows.Forms.Button();
            this.buttonThemSV = new System.Windows.Forms.Button();
            this.buttonTimSV = new System.Windows.Forms.Button();
            this.buttonDanhSachSV = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelName.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.panelName.Controls.Add(this.labelName);
            this.panelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelName.Location = new System.Drawing.Point(0, 0);
            this.panelName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(1154, 93);
            this.panelName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelName.Image = ((System.Drawing.Image)(resources.GetObject("labelName.Image")));
            this.labelName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelName.Location = new System.Drawing.Point(12, 27);
            this.labelName.Margin = new System.Windows.Forms.Padding(0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(399, 40);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "     Quản lý thông tin sinh viên";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.panelSidebar.Controls.Add(this.buttonThoat);
            this.panelSidebar.Controls.Add(this.buttonSuaThongTin);
            this.panelSidebar.Controls.Add(this.buttonXoaSinhVien);
            this.panelSidebar.Controls.Add(this.buttonThemSV);
            this.panelSidebar.Controls.Add(this.buttonTimSV);
            this.panelSidebar.Controls.Add(this.buttonDanhSachSV);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 93);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(293, 558);
            this.panelSidebar.TabIndex = 1;
            // 
            // buttonThoat
            // 
            this.buttonThoat.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonThoat.FlatAppearance.BorderSize = 0;
            this.buttonThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThoat.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.buttonThoat.Image = ((System.Drawing.Image)(resources.GetObject("buttonThoat.Image")));
            this.buttonThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThoat.Location = new System.Drawing.Point(0, 340);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonThoat.Size = new System.Drawing.Size(293, 68);
            this.buttonThoat.TabIndex = 5;
            this.buttonThoat.Text = "       Thoát";
            this.buttonThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonSuaThongTin
            // 
            this.buttonSuaThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSuaThongTin.FlatAppearance.BorderSize = 0;
            this.buttonSuaThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSuaThongTin.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.buttonSuaThongTin.Image = ((System.Drawing.Image)(resources.GetObject("buttonSuaThongTin.Image")));
            this.buttonSuaThongTin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSuaThongTin.Location = new System.Drawing.Point(0, 272);
            this.buttonSuaThongTin.Name = "buttonSuaThongTin";
            this.buttonSuaThongTin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonSuaThongTin.Size = new System.Drawing.Size(293, 68);
            this.buttonSuaThongTin.TabIndex = 4;
            this.buttonSuaThongTin.Text = "       Sửa thông tin";
            this.buttonSuaThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSuaThongTin.UseVisualStyleBackColor = true;
            this.buttonSuaThongTin.Click += new System.EventHandler(this.buttonSuaThongTin_Click);
            // 
            // buttonXoaSinhVien
            // 
            this.buttonXoaSinhVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonXoaSinhVien.FlatAppearance.BorderSize = 0;
            this.buttonXoaSinhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXoaSinhVien.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.buttonXoaSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("buttonXoaSinhVien.Image")));
            this.buttonXoaSinhVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonXoaSinhVien.Location = new System.Drawing.Point(0, 204);
            this.buttonXoaSinhVien.Name = "buttonXoaSinhVien";
            this.buttonXoaSinhVien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonXoaSinhVien.Size = new System.Drawing.Size(293, 68);
            this.buttonXoaSinhVien.TabIndex = 3;
            this.buttonXoaSinhVien.Text = "       Xóa sinh viên";
            this.buttonXoaSinhVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonXoaSinhVien.UseVisualStyleBackColor = true;
            this.buttonXoaSinhVien.Click += new System.EventHandler(this.buttonXoaSinhVien_Click);
            // 
            // buttonThemSV
            // 
            this.buttonThemSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonThemSV.FlatAppearance.BorderSize = 0;
            this.buttonThemSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThemSV.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.buttonThemSV.Image = ((System.Drawing.Image)(resources.GetObject("buttonThemSV.Image")));
            this.buttonThemSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThemSV.Location = new System.Drawing.Point(0, 136);
            this.buttonThemSV.Name = "buttonThemSV";
            this.buttonThemSV.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonThemSV.Size = new System.Drawing.Size(293, 68);
            this.buttonThemSV.TabIndex = 2;
            this.buttonThemSV.Text = "       Thêm sinh viên";
            this.buttonThemSV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThemSV.UseVisualStyleBackColor = true;
            this.buttonThemSV.Click += new System.EventHandler(this.buttonThemSV_Click);
            // 
            // buttonTimSV
            // 
            this.buttonTimSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTimSV.FlatAppearance.BorderSize = 0;
            this.buttonTimSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimSV.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.buttonTimSV.Image = ((System.Drawing.Image)(resources.GetObject("buttonTimSV.Image")));
            this.buttonTimSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTimSV.Location = new System.Drawing.Point(0, 68);
            this.buttonTimSV.Name = "buttonTimSV";
            this.buttonTimSV.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonTimSV.Size = new System.Drawing.Size(293, 68);
            this.buttonTimSV.TabIndex = 1;
            this.buttonTimSV.Text = "       Tìm thông tin";
            this.buttonTimSV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTimSV.UseVisualStyleBackColor = true;
            this.buttonTimSV.Click += new System.EventHandler(this.buttonTimSV_Click);
            // 
            // buttonDanhSachSV
            // 
            this.buttonDanhSachSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDanhSachSV.FlatAppearance.BorderSize = 0;
            this.buttonDanhSachSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDanhSachSV.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.buttonDanhSachSV.Image = ((System.Drawing.Image)(resources.GetObject("buttonDanhSachSV.Image")));
            this.buttonDanhSachSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDanhSachSV.Location = new System.Drawing.Point(0, 0);
            this.buttonDanhSachSV.Name = "buttonDanhSachSV";
            this.buttonDanhSachSV.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonDanhSachSV.Size = new System.Drawing.Size(293, 68);
            this.buttonDanhSachSV.TabIndex = 0;
            this.buttonDanhSachSV.Text = "       Danh sách sinh viên";
            this.buttonDanhSachSV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDanhSachSV.UseVisualStyleBackColor = true;
            this.buttonDanhSachSV.Click += new System.EventHandler(this.buttonDanhSachSV_Click);
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(219)))), ((int)(((byte)(223)))));
            this.panelForm.Controls.Add(this.pictureBox1);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(293, 93);
            this.panelForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(861, 558);
            this.panelForm.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(861, 558);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 651);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelName);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1170, 690);
            this.MinimumSize = new System.Drawing.Size(1170, 690);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Info";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDanhSachSV;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonSuaThongTin;
        private System.Windows.Forms.Button buttonXoaSinhVien;
        private System.Windows.Forms.Button buttonThemSV;
        private System.Windows.Forms.Button buttonTimSV;
    }
}