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
                command.CommandText = "Sp_ListarAreas";
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
    }
}
