﻿using SQL_ThucHanh.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_ThucHanh.GUI.SinhVien
{
    public partial class FormSuaSV : Form
    {
        private string ID = null;
        SinhVienBUS _SinhVienBUS = new SinhVienBUS();
        public FormSuaSV(string iD)
        {
            InitializeComponent();
            ID = iD;    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxHoTen.Text == string.Empty || textBoxMaLop.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Cảnh báo",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string Name = textBoxHoTen.Text;
                    string MaLop = textBoxMaLop.Text;
                    _SinhVienBUS.updateSV(ID, Name, MaLop);
                    MessageBox.Show("Sửa dữ liệu thành công! Vui lòng tải lại để xem dữ liệu.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
