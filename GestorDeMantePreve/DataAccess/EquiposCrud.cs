using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class EquiposCrud
    {
        ConnectionToSql conexion = new ConnectionToSql();
        SqlCommand command = new SqlCommand();
        SqlDataReader leer;
        DataTable tablaEquipos = new DataTable();


        //Atributos de los datos//
        private int Id;
        private string Equipo;
        private int NumeroEquipo;
        private int IdArea;

        //Funcion GET, SET//
        public int Id1 { get => Id; set => Id = value; }
        public string Equipo1 { get => Equipo; set => Equipo = value; }
        public int NumeroEquipo1 { get => NumeroEquipo; set => NumeroEquipo = value; }
        public int IdArea1 { get => IdArea; set => IdArea = value; }
        //Fin//


        //Funciones pra listar datos en el combobox/
        public DataTable ListarAreas()
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "sp_ListarAreas";
                command.CommandType = CommandType.StoredProcedure;
                leer = command.ExecuteReader();
                tablaEquipos.Load(leer);
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
            return tablaEquipos;
        }
        //Fin//


        //Funcion para mostrar los datos de la tabla de usuarios: GET//
        public DataTable GetEquipos()
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "Sp_GetEquiposTabla";
                command.CommandType = CommandType.StoredProcedure;
                leer = command.ExecuteReader();
                tablaEquipos.Load(leer);
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
            return tablaEquipos;
        }
        //Fin//


    }
}
