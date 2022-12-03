using SQL_ThucHanh.BUS;
using SQL_ThucHanh.DAO;
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
    public partial class FormThemLop : Form
    {
        private LopBUS _LopBUS = new LopBUS();

        public FormThemLop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Thêm lớp mới vào DB?", "Thông báo",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string ID = textBoxMaLop.Text;
                    string Name = textBoxTenLop.Text;
                    _LopBUS.addLop(ID, Name);

                    textBoxMaLop.Text = null;
                    textBoxTenLop.Text = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FormThemLop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
