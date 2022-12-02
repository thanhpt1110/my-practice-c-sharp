using System;
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
        public FormAdd()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=SV-TRƯỜNG-TIU;Initial Catalog=IT008_Test;Integrated Security=True";
        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Cảnh báo",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string msnv = textBoxMSNV.Text;
                    string Ten = textBoxHoTen.Text;
                    DateTime NgSinh = DateTime.Parse(dateTimePickerNgSinh.Text);
                    DateTime NgVL = DateTime.Parse(dateTimePickerNgVL.Text);

                    connection = new SqlConnection(str);
                    connection.Open();
                    command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO NhanVien (MSNV, HoTen, NgSinh, NgVL) VALUES ('" + msnv + "',N'" + Ten + "','" + NgSinh + "','" + NgVL + "')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm thông tin thành công!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Khóa chính không thể bị trùng! Vui lòng chọn MSNV khác.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }    
            }
            else
            {
                return;
            }
        }
    }
}
