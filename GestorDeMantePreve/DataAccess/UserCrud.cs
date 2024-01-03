using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class UserCrud: ConnectionToSql
    {

        SqlDataReader leer;
        DataTable tablaUsuarios = new DataTable();

        //Funcion para mostrar los datos de la tabla de usuarios: GET//
        public DataTable GetUsuarios()
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Usuarios";
                    leer = command.ExecuteReader();
                    tablaUsuarios.Load(leer);
                    connection.Close();
                    return tablaUsuarios;

                }
            }
        }
        //Fin//

        //Funcion para agregar datos a la tabla de usuarios: POST//
        public void PostUsuarios(string correo, string pass, string nombres, string apPaterno, string apMaterno)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Insert Into Usuarios Values ('"+correo+ "', '" + pass + "', '" + nombres + "', '" + apPaterno + "', '" + apMaterno + "')";
                    command.ExecuteNonQuery();
                }
            }
        }
        //Fin//
    }
}
