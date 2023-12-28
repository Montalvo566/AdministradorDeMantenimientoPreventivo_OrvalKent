using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConnectionToSql
    {
        //String de solo lectura para la cadena de conexión
        private readonly string connectionString;

        //Constructor
        public ConnectionToSql()
        {
            connectionString = "Server=; DataBase=; integrated security=";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
