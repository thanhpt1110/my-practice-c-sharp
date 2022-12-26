using SQL_ThucHanh.BUS;
using SQL_ThucHanh.GUI.Lop;
using SQL_ThucHanh.GUI.SinhVien;
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
    public partial class FormSV : Form
    {
        private string MaLop = null;
        public FormSV(string MaLop)
        {
            InitializeComponent();
            this.MaLop = MaLop;
        }
        SinhVienBUS _SinhVienBUS = new SinhVienBUS();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int y = e.RowIndex;
            int x = e.ColumnIndex;

            // If click button Edit
            if (x == 4 && y >= 0)
            {
                string ID = grid.Rows[y].Cells[1].Value.ToString();
                FormSuaSV frm = new FormSuaSV(ID);
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
                        _SinhVienBUS.deleteSVByID(ID);
                        MessageBox.Show("Xóa thành công! Vui lòng tải lại để xem dữ liệu.", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        [Obsolete]
        private void LoadData()
        {
            grid.Rows.Clear();
            List<SinhVien> listOfSV = new List<SinhVien>();
            listOfSV = _SinhVienBUS._getAllSVByMaLop(MaLop);
            foreach (var sv in listOfSV)
            {
                grid.Rows.Add(new object[] {
                    imageList1.Images[1],
                    sv.MSSV,
                    sv.HoTen,
                    sv.MaLop,
                    imageList1.Images[2],
                    imageList1.Images[3],
                });
            }
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormThemSV frm = new FormThemSV(MaLop);
            frm.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSV_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void grid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            if (y >= 0)
            {
                if (x == 4 || x == 5)
                    grid.Cursor = Cursors.Hand;
                else
                    grid.Cursor = Cursors.Default;
            }
            if (y == -1 && x == 1 || y == -1 && x == 3)
                grid.Cursor = Cursors.Hand;
        }

        private void grid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            grid.Cursor = Cursors.Default;
        }
    }
}
