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


        //Funcion para filtrar por el usuario asignado//
        public DataTable FiltrarActividadesPorUsuario(int idUsuario)
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "Sp_FiltrarHistorialUsuarios";
                command.CommandType = CommandType.StoredProcedure;
                // Agrega el parámetro para filtrar por usuario
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                leer = command.ExecuteReader();
                tablaUsuarios.Load(leer);
                command.Parameters.Clear();
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
                    command.Connection = conexion.AbrirConexion();
                    command.CommandText = "SELECT IdPuesto FROM Usuarios WHERE NumeroEmpleado = @NumeroEmpleado";
                    command.Parameters.AddWithValue("@NumeroEmpleado", numeroEmpleado);
                    command.CommandType = CommandType.Text;
                    int puesto = Convert.ToInt32(command.ExecuteScalar());
                    Console.WriteLine("Puesto obtenido en UserDao: " + puesto);
                    return puesto;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el puesto del usuario en UserDao: " + ex.Message);
                return 0;
            }
            finally
            {
                command.Connection = conexion.CerrarConexion();
            }
        }
        //Fin//


        //Funcion para hacer el regsitro del historial//
        public void RegistrarEnHistorialEnRevision(int idUsuario)
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "Sp_RegistrarHistorialActividades";
                command.CommandType = CommandType.StoredProcedure;

                // Agregar el parámetro @IdUsuario
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al invocar el procedimiento almacenado para registrar en historial: " + ex.Message);
                throw;
            }
            finally
            {
                command.Connection = conexion.CerrarConexion();
            }
        }
        //Fin//


        //Funcion para validar si hay actividades con el estado de "En revisión"//
        public bool ActividadesEnRevision()
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "SELECT COUNT(*) FROM Actividades WHERE Estatus = 3";
                command.CommandType = CommandType.Text;
                int cantidadActividadesEnRevision = Convert.ToInt32(command.ExecuteScalar());
                return cantidadActividadesEnRevision > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al verificar actividades en revisión: " + ex.Message);
                return false;
            }
            finally
            {
                command.Connection = conexion.CerrarConexion();
            }
        }
        //Fin//
    }
}
