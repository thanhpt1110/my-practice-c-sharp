using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Xml.Linq;

namespace SQL_ThucHanh.DAO
{
    internal class LopDAO
    {
        string connectionString = null, query = null;
        [Obsolete]

        public List<Lop> getAllLop()
        {
            // Update before Select all
            try
            {
                ConnectDB con = new ConnectDB();
                connectionString = con.getConnectionString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    query = "UPDATE Lop SET SL = (SELECT COUNT(MSSV) FROM SinhVien WHERE SinhVien.MaLop = Lop.MaLop GROUP BY SinhVien.MaLop)";
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

            List<Lop> listOfLop = new List<Lop>();
            try
            {
                ConnectDB con = new ConnectDB();
                connectionString = con.getConnectionString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    query = "SELECT * FROM Lop";
                    using (var command = new SqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string MaLop = reader["MaLop"].ToString();
                                string TenLop = reader["TenLop"].ToString();
                                int SL = (reader["SL"]) == DBNull.Value ? 0 : Convert.ToInt32(reader["SL"]);
                                Lop lop = new Lop(MaLop, TenLop, SL);
                                listOfLop.Add(lop);
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
            return listOfLop;
        }

        public void DeleteLopByID(string ID)
        {
            try
            {
                ConnectDB con = new ConnectDB();
                connectionString = con.getConnectionString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    query = "DELETE FROM Lop WHERE MaLop = '"+ID+"'";
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

        public void AddLop(string ID, string Name)
        {
            try
            {
                ConnectDB con = new ConnectDB();
                connectionString = con.getConnectionString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    query = "INSERT INTO Lop VALUES ('" + ID + "', N'" + Name + "', " + 0 + ")";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã tồn tại mã lớp này. Vui lòng nhập lại!", "Cảnh báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateLop(string ID, string Name)
        {
            try
            {
                ConnectDB con = new ConnectDB();
                connectionString = con.getConnectionString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    query = "UPDATE Lop SET TenLop = N'" + Name + "' WHERE MaLop = '" + ID + "'";
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
