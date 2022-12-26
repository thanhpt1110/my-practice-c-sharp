using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiLT_SQL_21520455_PhanTuanThanh
{
    public partial class FormAdd : Form
    {
        string connectionString = null, query = null;

        public FormAdd()
        {
            InitializeComponent();
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            this.ActiveControl = labelMSNV;
        }

        private bool checkThongTin()
        {
            bool check = true;
            string msnv = textBoxMSNV.Text;
            string Ten = textBoxHoTen.Text;
            if (msnv == string.Empty || Ten == string.Empty)
            {
                check = false;
            }
            return check;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!checkThongTin())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string msnv = textBoxMSNV.Text;
                string Ten = textBoxHoTen.Text;
                DateTime NgSinh = DateTime.Parse(dateTimePickerNgSinh.Text);
                DateTime NgVL = DateTime.Parse(dateTimePickerNgVL.Text);

                ConnectDB con = new ConnectDB();
                connectionString = con.getConnectionString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    query = "INSERT INTO NhanVien (MSNV, HoTen, NgSinh, NgVL) VALUES ('" + msnv + "',N'" + Ten + "','" + NgSinh + "','" + NgVL + "')";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Khóa chính không thể bị trùng! Vui lòng chọn MSNV khác.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
