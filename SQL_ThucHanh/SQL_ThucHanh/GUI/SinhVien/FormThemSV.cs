using SQL_ThucHanh.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_ThucHanh.GUI.SinhVien
{
    public partial class FormThemSV : Form
    {
        private string MaLop = null;
        public FormThemSV(string MaLop)
        {
            InitializeComponent();
            this.MaLop = MaLop; 
        }
        SinhVienBUS _SinhVienBUS = new SinhVienBUS();
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Thêm sv mới vào DB?", "Thông báo",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string ID = textBoxMSSV.Text;
                    string Name = textBoxHoTen.Text;
                    _SinhVienBUS.addSV(ID, Name, MaLop);    
                    MessageBox.Show("Thêm dữ liệu thành công! Vui lòng tải lại để xem dữ liệu.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxMSSV.Text = null;
                    textBoxHoTen.Text = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
