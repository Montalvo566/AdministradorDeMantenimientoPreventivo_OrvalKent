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
                    command.CommandText = "SELECT * FROM Usuarios WHERE Correo=@user AND Contrasena=@pass";
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
                            UserLoginCache.Correo = reader.GetString(6);
                            UserLoginCache.NombreCompleto = reader.GetString(1);
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


        public DataTable GetActividadesUsuarios(int idUsuario, out string errorMessage)
        {
            DataTable tablaActividades = new DataTable();
            errorMessage = null;

            try
            {
                using (var connection = AbrirConexion())
                {
                    command.Connection = connection;
                    command.CommandText = "Sp_GetActividadesUsuarios";
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar el parámetro al stored procedure
                    command.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    leer = command.ExecuteReader();
                    tablaActividades.Load(leer);
                }
            }
            catch (SqlException ex)
            {
                errorMessage = "Error SQL al obtener actividades: " + ex.Message;
            }
            catch (Exception ex)
            {
                errorMessage = "Error al obtener actividades: " + ex.Message;
            }
            finally
            {
                CerrarConexion();
            }

            return tablaActividades;
        }


    }
}
