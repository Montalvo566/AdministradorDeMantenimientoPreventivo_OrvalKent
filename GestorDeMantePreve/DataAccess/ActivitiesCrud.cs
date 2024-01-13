using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class ActivitiesCrud
    {
        ConnectionToSql conexion = new ConnectionToSql();
        SqlCommand command = new SqlCommand();
        SqlDataReader leer;
        DataTable tablaActividades = new DataTable();

        //Funciones pra listar datos en el combobox/
        public DataTable ListarAreas()
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "Sp_ListarAreasUser";
                command.CommandType = CommandType.StoredProcedure;
                leer = command.ExecuteReader();
                tablaActividades.Load(leer);
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
            return tablaActividades;
        }

        public DataTable ListarEquipos()
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "Sp_ListarEquipos";
                command.CommandType = CommandType.StoredProcedure;
                leer = command.ExecuteReader();
                tablaActividades.Load(leer);
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
            return tablaActividades;
        }

        public DataTable ListarFrecuencias()
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "Sp_ListarFrecuencias";
                command.CommandType = CommandType.StoredProcedure;
                leer = command.ExecuteReader();
                tablaActividades.Load(leer);
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
            return tablaActividades;
        }
        //Fin//


        //Funcion para mostrar los datos en la tabla de Actividades: GET//
        public DataTable GetActividades()
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "sp_MostrarActividades";
                command.CommandType = CommandType.StoredProcedure;
                leer = command.ExecuteReader();
                tablaActividades.Load(leer);
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
            return tablaActividades;
        }
        //Fin//


        //Funcion para insertar datos a la tabla de Actividades: POST//
        public void PostActividades(int IdAreaEmpresa, int IdEquipo, int Frecuencia, string FechaMantenimiento, string Actividad, string Formato)
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "sp_InsertarActividades";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IdAreaEmpresa", IdAreaEmpresa);
                command.Parameters.AddWithValue("@IdEquipo", IdEquipo);
                command.Parameters.AddWithValue("@Frecuencia", Frecuencia);
                command.Parameters.AddWithValue("@FechaMantenimiento", FechaMantenimiento);
                command.Parameters.AddWithValue("@Actividad", Actividad);
                command.Parameters.AddWithValue("@Formato", Formato);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (Exception ex)
            {
                string msj = ex.ToString();
            }
            finally
            {
                command.Connection = conexion.CerrarConexion();
            }
        }
        //Fin//

    }
}
