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
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace BaiTap_GUI_1
{
    public partial class FormTimThongTin : Form
    {

        public FormTimThongTin()
        {
            InitializeComponent();
            this.textBoxMSSV.Enabled = false;
            this.textBoxName.Enabled = false;
            this.textBoxScore.Enabled = false;
            this.textBoxClass.Enabled = false;
        }

        private void ButtonFindMSSV_Click(object sender, EventArgs e)
        {
            string mssv = null;
            try
            {
                mssv = this.textBoxFindMSSV.Text;
                CheckString.ValidateMSSV(mssv);
            }
            catch (CheckString)
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] lines = File.ReadAllLines("ThongTinSV.txt");

            bool found = false;
            for (int i = 0; i < lines.Length; ++i)
            {
                string[] words = lines[i].Split('-');
                if (words[0] == mssv)
                {
                    found = true;

                    this.textBoxMSSV.Enabled = true;
                    this.textBoxName.Enabled = true;
                    this.textBoxScore.Enabled = true;
                    this.textBoxClass.Enabled = true;

                    this.textBoxMSSV.Text = words[0];
                    this.textBoxName.Text = words[1];
                    this.textBoxClass.Text = words[2];
                    this.textBoxScore.Text = words[3];
                    return;
                }
            }
            if (!found)
                MessageBox.Show("Không tìm thấy MSSV này!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FormTimThongTin_Load(object sender, EventArgs e)
        {
            this.ButtonFindMSSV.Cursor = Cursors.Hand;
        }
    }
}
