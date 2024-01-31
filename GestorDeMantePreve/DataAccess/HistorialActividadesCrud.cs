using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class HistorialActividadesCrud
    {
        ConnectionToSql conexion = new ConnectionToSql();
        SqlCommand command = new SqlCommand();
        SqlDataReader leer;
        DataTable tablaHistorial = new DataTable();

        //Funcion para mostrar el historial de las actividades//
        public DataTable GetHistorialActividades()
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "Sp_ObtenerHistorialActividades";
                command.CommandType = CommandType.StoredProcedure;
                leer = command.ExecuteReader();
                tablaHistorial.Load(leer);
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
            return tablaHistorial;
        }
        //Fin//
    }
}
