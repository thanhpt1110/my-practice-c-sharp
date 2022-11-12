using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_GUI_1
{
    public partial class FormSuaThongTin : Form
    {
        
        public FormSuaThongTin()
        {
            InitializeComponent();
        }

        public static void ReadDataFromFile(List<SinhVien> QuanLySinhVien)
        {
            string[] lines = File.ReadAllLines("ThongTinSV.txt");
            for (int i = 0; i < lines.Length; ++i)
            {
                string[] data = lines[i].Split('-');
                SinhVien tmp = new SinhVien();
                tmp.MSSV = data[0];  
                tmp.Name = data[1];
                tmp.Class = data[2];
                tmp.Score = double.Parse(data[3]);
                QuanLySinhVien.Add(tmp);
            }
        }

        public static void WriteDataToFile(List<SinhVien> QuanLySinhVien)
        {            
            // Check file exist or not
            if (!File.Exists("ThongTinSV.txt"))
            {
                File.Create("ThongTinSV.txt").Close();
                using (StreamWriter sw = new StreamWriter("ThongTinSV.txt"))
                {
                    for (int i = 0; i < QuanLySinhVien.Count; ++i)
                    {
                        SinhVien tmp = QuanLySinhVien[i];
                        string[] words = { tmp.MSSV, tmp.Name, tmp.Class, tmp.Score.ToString() };
                        string data = String.Join("-", words);
                        sw.WriteLine(data);
                    }
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter("ThongTinSV.txt"))
                {
                    for(int i = 0; i < QuanLySinhVien.Count; ++i)
                    {
                        SinhVien tmp = QuanLySinhVien[i];
                        string[] words = { tmp.MSSV, tmp.Name, tmp.Class, tmp.Score.ToString() };
                        string data = String.Join("-", words);
                        sw.WriteLine(data);
                    }
                }
            }
        }
        
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            List<SinhVien> QuanLySinhVien = new List<SinhVien>();

            ReadDataFromFile(QuanLySinhVien);

            SinhVien sinhVien = new SinhVien();
            try
            {
                sinhVien.Name = this.textBoxName.Text;
                sinhVien.Class = this.textBoxClass.Text;
                CheckString.ValidateClass(sinhVien.Class);
            }
            catch (CheckString)
            {
                {
                    MessageBox.Show("Dữ liệu nhập vào không hợp lệ!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            try
            {
                sinhVien.Score = double.Parse(this.textBoxScore.Text);
            }
            catch (FormatException)
            {
                {
                    MessageBox.Show("Dữ liệu nhập vào không hợp lệ!", "Thông báo",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            bool found = false;
            string MSSV = this.textBoxMSSV.Text;
            for (int i = 0; i < QuanLySinhVien.Count; ++i)
            {
                if (QuanLySinhVien[i].MSSV == MSSV)
                {
                    found = true;
                    QuanLySinhVien[i].Name = sinhVien.Name;
                    QuanLySinhVien[i].Class = sinhVien.Class;
                    QuanLySinhVien[i].Score = sinhVien.Score;
                }
            }
            if (!found)
            {
                MessageBox.Show("Không tồn tại MSSV này! Hãy qua phần lưu thông tin để thêm.", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            WriteDataToFile(QuanLySinhVien);

            //Notify that we saved successful
            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.textBoxMSSV.Text = null;
            this.textBoxName.Text = null;
            this.textBoxClass.Text = null;
            this.textBoxScore.Text = null;
        }

        private void FormSuaThongTin_Load(object sender, EventArgs e)
        {
            this.ButtonUpdate.Cursor = Cursors.Hand;
        }
    }
}
