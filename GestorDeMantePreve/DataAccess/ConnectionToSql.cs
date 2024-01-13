using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public class ConnectionToSql
    {


        private SqlConnection conexion = new SqlConnection("Server=DESKTOP-3FIQUSR; DataBase=SAMP_BDPruebas; integrated security=true");
        public SqlConnection AbrirConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Closed) conexion.Open();
            {
                return conexion;
            }
        }
        public SqlConnection CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open) conexion.Close();
            {
                return conexion;
            }
        }
    }
}
