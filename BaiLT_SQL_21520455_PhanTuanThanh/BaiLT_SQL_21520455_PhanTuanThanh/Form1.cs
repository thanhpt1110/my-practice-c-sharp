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
            dataGridView1.DataSource= table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str); 
            connection.Open();
            loaddata();
        }
    }
}
