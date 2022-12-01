namespace BaiLT_SQL_21520455_PhanTuanThanh
{
    partial class Form1
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
            this.labelNgayVaoLam = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelMSNV = new System.Windows.Forms.Label();
            this.textBoxMSNV = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnMSNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNgSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNgVL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelNgayVaoLam);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.labelHoTen);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.labelNgaySinh);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.labelMSNV);
            this.panel1.Controls.Add(this.textBoxMSNV);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 183);
            this.panel1.TabIndex = 0;
            // 
            // labelNgayVaoLam
            // 
            this.labelNgayVaoLam.AutoSize = true;
            this.labelNgayVaoLam.Location = new System.Drawing.Point(335, 119);
            this.labelNgayVaoLam.Name = "labelNgayVaoLam";
            this.labelNgayVaoLam.Size = new System.Drawing.Size(109, 21);
            this.labelNgayVaoLam.TabIndex = 7;
            this.labelNgayVaoLam.Text = "Ngày vào làm:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(450, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(202, 29);
            this.textBox3.TabIndex = 6;
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Location = new System.Drawing.Point(335, 39);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(59, 21);
            this.labelHoTen.TabIndex = 5;
            this.labelHoTen.Text = "Họ tên:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(450, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 29);
            this.textBox2.TabIndex = 4;
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Location = new System.Drawing.Point(25, 119);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(83, 21);
            this.labelNgaySinh.TabIndex = 3;
            this.labelNgaySinh.Text = "Ngày sinh:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 29);
            this.textBox1.TabIndex = 2;
            // 
            // labelMSNV
            // 
            this.labelMSNV.AutoSize = true;
            this.labelMSNV.Location = new System.Drawing.Point(25, 36);
            this.labelMSNV.Name = "labelMSNV";
            this.labelMSNV.Size = new System.Drawing.Size(81, 21);
            this.labelMSNV.TabIndex = 1;
            this.labelMSNV.Text = "Mã số NV:";
            // 
            // textBoxMSNV
            // 
            this.textBoxMSNV.Location = new System.Drawing.Point(114, 33);
            this.textBoxMSNV.Name = "textBoxMSNV";
            this.textBoxMSNV.Size = new System.Drawing.Size(202, 29);
            this.textBoxMSNV.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 183);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(764, 338);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMSNV,
            this.ColumnHoTen,
            this.ColumnNgSinh,
            this.ColumnNgVL});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(20, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(724, 298);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnMSNV
            // 
            this.ColumnMSNV.HeaderText = "Mã số NV";
            this.ColumnMSNV.Name = "ColumnMSNV";
            this.ColumnMSNV.ReadOnly = true;
            this.ColumnMSNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnHoTen
            // 
            this.ColumnHoTen.HeaderText = "Họ tên";
            this.ColumnHoTen.Name = "ColumnHoTen";
            this.ColumnHoTen.ReadOnly = true;
            this.ColumnHoTen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnNgSinh
            // 
            this.ColumnNgSinh.HeaderText = "Ngày sinh";
            this.ColumnNgSinh.Name = "ColumnNgSinh";
            this.ColumnNgSinh.ReadOnly = true;
            this.ColumnNgSinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnNgVL
            // 
            this.ColumnNgVL.HeaderText = "Ngày vào làm";
            this.ColumnNgVL.Name = "ColumnNgVL";
            this.ColumnNgVL.ReadOnly = true;
            this.ColumnNgVL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 521);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(780, 560);
            this.MinimumSize = new System.Drawing.Size(780, 560);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelNgayVaoLam;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelNgaySinh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelMSNV;
        private System.Windows.Forms.TextBox textBoxMSNV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMSNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNgSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNgVL;
    }
}

