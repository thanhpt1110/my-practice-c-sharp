using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiLT_SQL_21520455_PhanTuanThanh
{
    internal class ConnectDB
    {
        Configuration config;

        public ConnectDB()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        public string getConnectionString()
        {
            return config.ConnectionStrings.ConnectionStrings["IT008-LT"].ConnectionString;
        }
    }
}
