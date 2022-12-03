using SQL_ThucHanh.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_ThucHanh.GUI.Lop
{
    public partial class FormSuaLop : Form
    {
        private string ID = null;
        LopBUS _LopBus = new LopBUS();  
        public FormSuaLop(string ID)
        {
            InitializeComponent();
            this.ID = ID;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Cảnh báo",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string Name = textBoxTenLop.Text;
                    _LopBus.updateLop(ID, Name);
                    MessageBox.Show("Sửa dữ liệu thành công! Vui lòng tải lại để xem dữ liệu.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
