using System;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;

namespace DataAccess
{
    public class UserDao : ConnectionToSql
    {
        SqlCommand command = new SqlCommand();
        SqlDataReader leer;
        DataTable tablaUsuarios = new DataTable();

        public bool Login(string user, string pass)
        {
            try
            {
                using (var connection = AbrirConexion())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Usuarios where Correo=@user and Pass=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // Método para obtener los datos del usuario
                        while (reader.Read())
                        {
                            UserLoginCache.Id = reader.GetInt32(0);
                            UserLoginCache.Correo = reader.GetString(1);
                            UserLoginCache.Nombres = reader.GetString(3);
                        }
                        // Fin
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                string msj = ex.ToString();
                // Puedes manejar la excepción según tus necesidades
                return false;
            }
            finally
            {
                CerrarConexion();
            }
        }
    }
}
