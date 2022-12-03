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
        string connectionString = @"Data Source=SV-TRƯỜNG-TIU;Initial Catalog=IT008;Integrated Security=True";
        SqlConnection con;
        SqlCommand sqlCommand = null;
        string sql = null;
        [Obsolete]

        public List<SinhVien> getAllSVByMaLop(string MaLop)
        {
            List<SinhVien> listOfSV = new List<SinhVien>();
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                sql = "SELECT * FROM SinhVien WHERE MaLop = '"+MaLop+"'";
                using (var command = new SqlCommand(sql, con))
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
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listOfSV;
        }

        public void DeleteSVByID(string ID)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                sql = "DELETE FROM SinhVien WHERE MSSV = '" + ID + "'";
                sqlCommand = new SqlCommand(sql, con);
                sqlCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public void AddSV(string ID, string Name, string MaLop)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                sql = "INSERT INTO SinhVien VALUES ('" + ID + "', N'" + Name + "', '" + MaLop + "')";
                sqlCommand = new SqlCommand(sql, con);
                sqlCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public void UpdateSV(string ID, string Name, string MaLop)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                sql = "UPDATE SinhVien SET TenSV = N'" + Name + "', MaLop = '"+MaLop+"' WHERE MSSV = '" + ID + "'";
                sqlCommand = new SqlCommand(sql, con);
                sqlCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
