using System;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;
using System.Data;

namespace DataAccess
{
    public class UserDao : ConnectionToSql
    {
        ConnectionToSql conexion = new ConnectionToSql();
        SqlCommand command = new SqlCommand();
        SqlDataReader leer;
        DataTable tablaUsuarios = new DataTable();

        //Atributos de datos//
        private int Id;
        private int Estatus;
        private int IdUsuario;

        //Funcion GET, SET
        public int Estatus1 { get => Estatus; set => Estatus = value; }
        public int Id1 { get => Id; set => Id = value; }
        public int IdUsuario1 { get => IdUsuario; set => IdUsuario = value; }
        //Fin//


        //Funcion para iniciar sesion//
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
                            UserLoginCache.Puesto = reader.GetInt32(5);
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
        //Fin//


        //Funcion para obtener las actividades asignadas a los usuarios//
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
        //Fin//


        //Funcion para cambiar el estatus de la actividad a termiando//
        public void CambiarEstadoActividad()
        {
            try
            {
                using (var connection = conexion.AbrirConexion())
                {
                    command.Connection = connection;
                    command.CommandText = "CambiarEstadoActividad";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", Id);
                    command.Parameters.AddWithValue("@Estatus", Estatus);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en CambiarEstadoActividad: " + ex.ToString());
                throw; // Lanza la excepción para que sea manejada en la capa de presentación
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
        //Fin//



    }
}
