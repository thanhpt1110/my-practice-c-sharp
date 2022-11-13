using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;

namespace BaiTap_GUI_1
{
    public partial class FormThemSV : System.Windows.Forms.Form
    { 
        public FormThemSV()
        {
            InitializeComponent();
        }

        private void buttonSaveClick(object sender, EventArgs e)
        {
            SinhVien sinhVien = new SinhVien();
            try
            {
                sinhVien.MSSV = this.textBoxMSSV.Text;
                sinhVien.Name = this.textBoxName.Text;
                sinhVien.Class = this.textBoxClass.Text;
                CheckString.ValidateMSSV(sinhVien.MSSV);
                CheckString.ValidateClass(sinhVien.Class);
            }
            catch(CheckString)
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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

            string[] lines = File.ReadAllLines("ThongTinSV.txt");
            bool found = false;

            string[] words;
            for (int i = 0; i < lines.Length; ++i)
            {
                words = lines[i].Split('-');
                if (words[0] == this.textBoxMSSV.Text)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                MessageBox.Show("Đã tồn tại MSSV này! Nếu muốn đổi thông tin hãy qua mục 'Sửa thông tin'.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Lưu thông tin thành công!", "Thông báo",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.textBoxMSSV.Text = null;
            this.textBoxName.Text = null;
            this.textBoxClass.Text = null;
            this.textBoxScore.Text = null;

            string[] joinWords = {sinhVien.MSSV, sinhVien.Name, sinhVien.Class, sinhVien.Score.ToString()};
            string data = String.Join("-", joinWords);

            // Check file exist or not
            if (!File.Exists("ThongTinSV.txt"))
            {
                File.Create("ThongTinSV.txt").Close();
                using (StreamWriter sw = File.AppendText("ThongTinSV.txt"))
                    sw.WriteLine(data);
            }
            else
            {
                using (StreamWriter sw = File.AppendText("ThongTinSV.txt"))
                    sw.WriteLine(data);
            }
        }

        private void FormThemSV_Load(object sender, EventArgs e)
        {
            this.buttonSave.Cursor = Cursors.Hand;
        }
    }
}
