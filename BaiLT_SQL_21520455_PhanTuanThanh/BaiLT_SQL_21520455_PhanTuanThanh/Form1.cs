using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace BaiLT_SQL_21520455_PhanTuanThanh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=SV-TRƯỜNG-TIU;Initial Catalog=IT008_Test;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM NhanVien";
            adapter.SelectCommand= command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str); 
            connection.Open();
            loaddata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = dataGridView1;
            int i = e.RowIndex;
            if (i >= 0)
            {
                textBoxMSNV.Text = dgv.Rows[i].Cells[0].Value.ToString();
                textBoxHoTen.Text = dgv.Rows[i].Cells[1].Value.ToString();
                dateTimePickerNgSinh.Text = dgv.Rows[i].Cells[2].Value.ToString();
                dateTimePickerNgVL.Text = dgv.Rows[i].Cells[3].Value.ToString();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                command.Connection.CreateCommand();
                command.CommandText = "DELETE FROM NhanVien WHERE MSNV = '" + textBoxMSNV.Text + "'";
                command.ExecuteNonQuery();
                loaddata();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Cảnh báo",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string msnv = textBoxMSNV.Text;
                string Ten = textBoxHoTen.Text;
                DateTime NgSinh = DateTime.Parse(dateTimePickerNgSinh.Text);
                DateTime NgVL = DateTime.Parse(dateTimePickerNgVL.Text);

                command.Connection.CreateCommand();
                command.CommandText = "UPDATE NhanVien SET HoTen = N'"+Ten+"', NgSinh = '"+NgSinh+"', NgVL = '"+NgVL+"' WHERE MSNV = '" + msnv + "'";
                command.ExecuteNonQuery();
                loaddata();
            }   
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAdd form = new FormAdd();
            form.ShowDialog();
            loaddata();
        }
    }
}
