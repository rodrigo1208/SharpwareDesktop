using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.DAO 
{
    public class ConnectionManager : IDisposable
    {
        private readonly MySqlConnection _con;

        public ConnectionManager(MySqlConnection con)
        {
            if(con == null)
            {
                throw new NullReferenceException("O objeto n�o pode ser nulo (Problema de conex�o) "); 
            }
            _con = con;
        }

        public ConnectionManager Open()
        {
            _con.Open();
            return this;
        }

        public ConnectionManager Close()
        {
            if (_con != null)
            {
                _con.Close();
            }

            return this;
        }

        public void Dispose()
        {
            Close();
        }
    }
}
