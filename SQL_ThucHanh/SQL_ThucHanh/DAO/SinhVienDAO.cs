    using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_ThucHanh.DAO
{
    internal class SinhVienDAO
    {
        string connectionString = null, query = null;
        [Obsolete]

        public List<SinhVien> getAllSVByMaLop(string MaLop)
        {
            List<SinhVien> listOfSV = new List<SinhVien>();
            try
            {
                ConnectDB con = new ConnectDB();
                connectionString = con.getConnectionString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    query = "SELECT * FROM SinhVien WHERE MaLop = '" + MaLop + "'";
                    using (var command = new SqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string MSSV = reader["MSSV"].ToString();
                                string TenLop = reader["TenSV"].ToString();
                                SinhVien sv = new SinhVien(MSSV, TenLop, MaLop);
                                listOfSV.Add(sv);
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listOfSV;
        }

        public void DeleteSVByID(string ID)
        {
            try
            {
                ConnectDB con = new ConnectDB();
                connectionString = con.getConnectionString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    query = "DELETE FROM SinhVien WHERE MSSV = '" + ID + "'";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddSV(string ID, string Name, string MaLop)
        {
            try
            {
                ConnectDB con = new ConnectDB();
                connectionString = con.getConnectionString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    query = "INSERT INTO SinhVien VALUES ('" + ID + "', N'" + Name + "', '" + MaLop + "')";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã tồn tại MSSV này. Vui lòng nhập lại!", "Cảnh báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void UpdateSV(string ID, string Name, string MaLop)
        {
            try
            {
                ConnectDB con = new ConnectDB();
                connectionString = con.getConnectionString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    query = "UPDATE SinhVien SET TenSV = N'" + Name + "', MaLop = '"+MaLop+"' WHERE MSSV = '" + ID + "'";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
