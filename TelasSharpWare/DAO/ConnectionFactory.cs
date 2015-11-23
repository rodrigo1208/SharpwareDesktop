using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.DAO
{
    public class ConnectionFactory
    {
        private ConnectionFactory()
        { }

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString());
        }
    }
}
