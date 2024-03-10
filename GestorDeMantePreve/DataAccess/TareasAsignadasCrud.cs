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

        //Atributos de datos//
        private int Id;
        private int IdArea;
        private int IdEquipo;
        private int IdFrecuencia;
        private string Actividad;
        private string Registro;
        private int Estatus;
        private int IdUsuarioRegistra;
        private int IdUsuarioAsignado;
        private string FechaAsignado;

        //Funcion GET, SET
        public int IdArea1 { get => IdArea; set => IdArea = value; }
        public int IdEquipo1 { get => IdEquipo; set => IdEquipo = value; }
        public int IdFrecuencia1 { get => IdFrecuencia; set => IdFrecuencia = value; }
        public string Actividad1 { get => Actividad; set => Actividad = value; }
        public string Registro1 { get => Registro; set => Registro = value; }
        public int Estatus1 { get => Estatus; set => Estatus = value; }
        public int IdUsuarioRegistra1 { get => IdUsuarioRegistra; set => IdUsuarioRegistra = value; }
        public int IdUsuarioAsignado1 { get => IdUsuarioAsignado; set => IdUsuarioAsignado = value; }
        public string FechaAsignado1 { get => FechaAsignado; set => FechaAsignado = value; }
        public int Id1 { get => Id; set => Id = value; }
        //Fin//


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
            return tablaActividades;
        }
    //Fin//


}
}
