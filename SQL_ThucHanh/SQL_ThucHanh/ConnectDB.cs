using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_ThucHanh
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
            return config.ConnectionStrings.ConnectionStrings["IT008-TH"].ConnectionString;
        }
    }
}
