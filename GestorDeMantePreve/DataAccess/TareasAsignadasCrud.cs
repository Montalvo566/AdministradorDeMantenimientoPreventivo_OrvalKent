using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class TareasAsignadasCrud
    {
        ConnectionToSql conexion = new ConnectionToSql();
        SqlCommand command = new SqlCommand();
        SqlDataReader leer;
        DataTable tablaActividades = new DataTable();

        //Mostrar la tabla de las actividad//
        public DataTable GetActividades()
        {

            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "Sp_GetActividadesTabla";
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


        //Mostrar los usuarios en el combobox//
        public DataTable ListarUsuarios()
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "Sp_ListarUsuariosRegistra";
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


        //Funcion para filtrar por el usuario asignado//
        public DataTable GetActividadesPorUsuario(int idUsuario)
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "Sp_FiltrarActividadesPorUsuario";
                command.CommandType = CommandType.StoredProcedure;

                // Agrega el parámetro para filtrar por usuario
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);

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
