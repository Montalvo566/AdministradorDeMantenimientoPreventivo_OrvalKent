using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class HistorialDataAccess
    {
        ConnectionToSql conexion = new ConnectionToSql();
        SqlCommand command = new SqlCommand();
        SqlDataReader leer;
        DataTable tablaUsuarios = new DataTable();

        //Funcion para mostrar el historial de las actividades//
        public DataTable GetHistorialActividades()
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "Sp_ObtenerHistorialActividades";
                command.CommandType = CommandType.StoredProcedure;
                leer = command.ExecuteReader();
                tablaUsuarios.Load(leer);
                leer.Close();

            }
            catch (Exception ex)
            {
                string msj = ex.ToString();
            }
            finally
            {
                command.Connection = conexion.CerrarConexion();
            }
            return tablaUsuarios;
        }
        //Fin//


        //Funcion para optener el numero de empleado mediante el codigo de barras//
        public int ObtenerPuestoPorNumeroEmpleado(int numeroEmpleado)
        {
            try
            {
                using (var connection = conexion.AbrirConexion())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT IdPuesto FROM Usuarios WHERE NumeroEmpleado = @NumeroEmpleado";
                    command.Parameters.AddWithValue("@NumeroEmpleado", numeroEmpleado);
                    command.CommandType = CommandType.Text;

                    int puesto = Convert.ToInt32(command.ExecuteScalar());

                    Console.WriteLine("Puesto obtenido en UserDao: " + puesto);

                    return puesto;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el puesto del usuario en UserDao: " + ex.Message);
                return 0;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
        //Fin//


        //Funcion para hacer el regsitro del historial//
        public void RegistrarEnHistorialEnRevision()
        {
            try
            {
                using (var connection = conexion.AbrirConexion())
                {
                    command.Connection = connection;
                    command.CommandText = "Sp_RegistrarHistorialActividades";
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al invocar el procedimiento almacenado para registrar en historial: " + ex.Message);
                throw; // Lanza la excepción para que sea manejada en capas superiores
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
        //Fin//
    }
}
