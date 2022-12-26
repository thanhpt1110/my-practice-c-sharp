using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace BaiTap_GUI_1
{
    public partial class FormDanhSach : Form
    {
        public FormDanhSach()
        {
            InitializeComponent();
        }

        private void FormDanhSach_Load(object sender, EventArgs e)
        {
            dataGridViewSV.RowTemplate.MinimumHeight = 50;
            dataGridViewSV.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 14F);

            List<SinhVien> DSSV = new List<SinhVien>();
            string[] lines = File.ReadAllLines("ThongTinSV.txt");

            for (int i = 0; i < lines.Length; ++i)
            {
                string[] words = lines[i].Split('-');
                SinhVien sv = new SinhVien();
                sv.MSSV = words[0];
                sv.Name = words[1];
                sv.Class = words[2];
                sv.Score = double.Parse(words[3]);
                DSSV.Add(sv);
            }

            foreach (SinhVien x in DSSV)
            {
                dataGridViewSV.Rows.Add(x.MSSV, x.Name, x.Class, x.Score.ToString());
            }
        }
    }
}
