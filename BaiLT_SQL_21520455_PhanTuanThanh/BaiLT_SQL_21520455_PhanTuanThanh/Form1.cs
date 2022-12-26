using Microsoft.Win32;
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
        string connectionString = null, query = null;
        
        public Form1()
        {
            InitializeComponent();
        }

        void loaddata()
        {
            try
            {
                ConnectDB con = new ConnectDB();
                connectionString = con.getConnectionString();
                using (SqlConnection connection = new SqlConnection (connectionString))
                {
                    connection.Open();
                    query = "SELECT * FROM NhanVien";
                    using (var command  = new SqlCommand (query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        DataTable table = new DataTable();
                        adapter.SelectCommand = command;
                        table.Clear();
                        adapter.Fill(table);
                        dataGridView1.DataSource = table;
                    }
                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = labelMSNV;
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
                try
                {
                    ConnectDB con = new ConnectDB();
                    connectionString = con.getConnectionString();
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        query = "DELETE FROM NhanVien WHERE MSNV = '" + textBoxMSNV.Text + "'";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                    loaddata();
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Cảnh báo",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
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
                        query = "UPDATE NhanVien SET HoTen = N'" + Ten + "', NgSinh = '" + NgSinh + "', NgVL = '" + NgVL + "' WHERE MSNV = '" + msnv + "'";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                    loaddata();
                    MessageBox.Show("Sửa dữ liệu thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
