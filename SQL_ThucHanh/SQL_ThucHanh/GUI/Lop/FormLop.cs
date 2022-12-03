using SQL_ThucHanh.BUS;
using SQL_ThucHanh.GUI.Lop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_ThucHanh
{
    public partial class FormLop : Form
    {
        public FormLop()
        {
            InitializeComponent();
        }
        LopBUS _LopBUS = new LopBUS();

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int y = e.RowIndex;
            int x = e.ColumnIndex;

            // If click button Edit
            if (x == 4 && y >= 0)
            {
                string ID = grid.Rows[y].Cells[1].Value.ToString();
                FormSuaLop frm = new FormSuaLop(ID);
                frm.ShowDialog();
            }
            // If click button Delete
            if (x == 5 && y >= 0)
            {
                string ID = grid.Rows[y].Cells[1].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        _LopBUS.deleteLop(ID);
                        MessageBox.Show("Xóa thành công! Vui lòng tải lại để xem dữ liệu.", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            if (x >= 0 && x <= 3 && y >= 0)
            {
                string MaLop = grid.Rows[y].Cells[1].Value.ToString();
                FormSV frm = new FormSV(MaLop);
                frm.ShowDialog();
            }

        }

        private void LoadData()
        {
            grid.Rows.Clear();
            List<Lop> listOfLop = new List<Lop>();
            listOfLop = _LopBUS.getAllLop();
            foreach (var lop in listOfLop)
            {
                grid.Rows.Add(new object[] {
                    imageList1.Images[0],
                    lop.MaLop,
                    lop.TenLop,
                    lop.SL,
                    imageList1.Images[2],
                    imageList1.Images[3],
                });
            }
        }

        [Obsolete]
        private void buttonReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormThemLop frm = new FormThemLop();
            frm.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void FormLop_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
