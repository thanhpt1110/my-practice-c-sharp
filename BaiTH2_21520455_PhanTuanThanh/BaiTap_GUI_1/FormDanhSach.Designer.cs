namespace BaiTap_GUI_1
{
    partial class FormDanhSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewSV = new System.Windows.Forms.DataGridView();
            this.ColumnMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSV
            // 
            this.dataGridViewSV.AllowUserToAddRows = false;
            this.dataGridViewSV.AllowUserToDeleteRows = false;
            this.dataGridViewSV.AllowUserToResizeColumns = false;
            this.dataGridViewSV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(197)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(187)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewSV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(197)))), ((int)(((byte)(200)))));
            this.dataGridViewSV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewSV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSV.ColumnHeadersHeight = 70;
            this.dataGridViewSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMSSV,
            this.ColumnTen,
            this.ColumnLop,
            this.ColumnDiem});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(197)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(187)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSV.EnableHeadersVisualStyles = false;
            this.dataGridViewSV.GridColor = System.Drawing.Color.White;
            this.dataGridViewSV.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewSV.Name = "dataGridViewSV";
            this.dataGridViewSV.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(197)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(187)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSV.RowHeadersVisible = false;
            this.dataGridViewSV.RowHeadersWidth = 50;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewSV.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(197)))), ((int)(((byte)(200)))));
            this.dataGridViewSV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewSV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(187)))), ((int)(((byte)(195)))));
            this.dataGridViewSV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewSV.RowTemplate.DividerHeight = 2;
            this.dataGridViewSV.RowTemplate.Height = 30;
            this.dataGridViewSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSV.Size = new System.Drawing.Size(821, 518);
            this.dataGridViewSV.TabIndex = 0;
            // 
            // ColumnMSSV
            // 
            this.ColumnMSSV.HeaderText = "MSSV";
            this.ColumnMSSV.MinimumWidth = 50;
            this.ColumnMSSV.Name = "ColumnMSSV";
            this.ColumnMSSV.ReadOnly = true;
            this.ColumnMSSV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnMSSV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnTen
            // 
            this.ColumnTen.HeaderText = "Họ và tên";
            this.ColumnTen.MinimumWidth = 100;
            this.ColumnTen.Name = "ColumnTen";
            this.ColumnTen.ReadOnly = true;
            this.ColumnTen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnTen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnLop
            // 
            this.ColumnLop.HeaderText = "Lớp";
            this.ColumnLop.MinimumWidth = 50;
            this.ColumnLop.Name = "ColumnLop";
            this.ColumnLop.ReadOnly = true;
            this.ColumnLop.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnLop.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnDiem
            // 
            this.ColumnDiem.HeaderText = "Điểm trung bình";
            this.ColumnDiem.MinimumWidth = 30;
            this.ColumnDiem.Name = "ColumnDiem";
            this.ColumnDiem.ReadOnly = true;
            this.ColumnDiem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnDiem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FormDanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(197)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(861, 558);
            this.Controls.Add(this.dataGridViewSV);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDanhSach";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "FormDanhSach";
            this.Load += new System.EventHandler(this.FormDanhSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiem;
    }
}