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
    public partial class FormXoaSV : Form
    {
        public FormXoaSV()
        {
            InitializeComponent();
            customDesign();
        }

        private void customDesign()
        {
            labelXoaThanhCong.Visible = false; 
            labelXoaThatBai.Visible = false;
        }

        private void ButtonXoaMSSV_Click(object sender, EventArgs e)
        {
            string mssv = null;
            try
            {
                mssv = this.textBoxXoaMSSV.Text;
                CheckString.ValidateMSSV(mssv);
            }
            catch(CheckString)
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Đọc dữ liệu từ file
            string[] lines = File.ReadAllLines("ThongTinSV.txt");
            List<SinhVien> DSSV = new List<SinhVien>();

            bool found = false;
            int idx = -1;

            for (int i = 0; i < lines.Length; ++i)
            {
                string[] words = lines[i].Split('-');
                SinhVien sv = new SinhVien();
                sv.MSSV = words[0];
                sv.Name = words[1];
                sv.Class = words[2];
                sv.Score = double.Parse(words[3]);

                if (words[0] == mssv)
                {
                    found = true;
                    idx = i;
                }
                DSSV.Add(sv);  
            }

            if (!found)
            {
                labelXoaThanhCong.Visible = false; 
                labelXoaThatBai.Visible = true;
            }
            else
            {
                DSSV.RemoveAt(idx);
                labelXoaThatBai.Visible = false;
                labelXoaThanhCong.Visible = true;
            }

            // Load dữ liệu trong list vào file
            for (int i = 0; i < DSSV.Count; ++i)
            {
                if (!File.Exists("ThongTinSV.txt"))
                {
                    File.Create("ThongTinSV.txt").Close();
                    using (StreamWriter sw = new StreamWriter("ThongTinSV.txt"))
                    {
                        foreach (SinhVien x in DSSV)
                            sw.WriteLine(x);
                    }
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter("ThongTinSV.txt"))
                    {
                        foreach (SinhVien x in DSSV)
                            sw.WriteLine(x);
                    }
                }
            }
        }

        private void FormXoaSV_Load(object sender, EventArgs e)
        {
            this.ButtonXoaMSSV.Cursor = Cursors.Hand;
        }
    }
}
