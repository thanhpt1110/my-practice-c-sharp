using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SQL_ThucHanh.DAO
{
    internal class LopDAO
    {
        string connectionString = @"Data Source=SV-TRƯỜNG-TIU;Initial Catalog=IT008;Integrated Security=True";
        SqlConnection con;
        SqlCommand sqlCommand = null;
        string sql = null;
        [Obsolete]

        public List<Lop> getAllLop()
        {
            List<Lop> listOfLop = new List<Lop>();
            // Update before Select all
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                sql = "UPDATE Lop SET SL = (SELECT COUNT(MSSV) FROM SinhVien WHERE SinhVien.MaLop = Lop.MaLop GROUP BY SinhVien.MaLop)";               
                sqlCommand = new SqlCommand(sql, con);
                sqlCommand.ExecuteNonQuery();
                    

                sql = "SELECT * FROM Lop";
                using (var command = new SqlCommand(sql, con))
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
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listOfLop;
        }

        public void DeleteLopByID(string ID)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                sql = "DELETE FROM Lop WHERE MaLop = '"+ID+"'";
                sqlCommand = new SqlCommand(sql, con);
                sqlCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddLop(string ID, string Name)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                sql = "INSERT INTO Lop VALUES ('"+ID+"', N'"+Name+"', "+0+")";
                sqlCommand = new SqlCommand(sql, con);
                sqlCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateLop(string ID, string Name)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                sql = "UPDATE Lop SET TenLop = N'"+Name+"' WHERE MaLop = '"+ID+"'";
                sqlCommand = new SqlCommand(sql, con);
                sqlCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
