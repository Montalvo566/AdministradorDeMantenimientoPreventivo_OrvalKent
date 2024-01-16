using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class AreasCrud
    {
        ConnectionToSql conexion = new ConnectionToSql();
        SqlCommand command = new SqlCommand();
        SqlDataReader leer;
        DataTable tablaAreas = new DataTable();


        //Atribuos de los datos//
        private int Id;
        private string Zona;
        private int IdDepartamento;

        //Funcion GET, SET//
        public int Id1 { get => Id; set => Id = value; }
        public string Zona1 { get => Zona; set => Zona = value; }
        public int IdDepartamento1 { get => IdDepartamento; set => IdDepartamento = value; }
        //Fin//


        //Funciones pra listar datos en el combobox/
        public DataTable ListarDepartamentos()
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "sp_ListarDepartamentos";
                command.CommandType = CommandType.StoredProcedure;
                leer = command.ExecuteReader();
                tablaAreas.Load(leer);
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
            return tablaAreas;
        }
        //Fin//


        //Funcion para mostrar los datos de la tabla de usuarios: GET//
        public DataTable GetAreas()
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "Sp_GetAreasTabla";
                command.CommandType = CommandType.StoredProcedure;
                leer = command.ExecuteReader();
                tablaAreas.Load(leer);
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
            return tablaAreas;
        }
        //Fin//


    }
}
