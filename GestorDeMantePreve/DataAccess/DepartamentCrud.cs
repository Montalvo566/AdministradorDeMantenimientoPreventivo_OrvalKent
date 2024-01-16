using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class DepartamentCrud
    {
        ConnectionToSql conexion = new ConnectionToSql();
        SqlCommand command = new SqlCommand();
        SqlDataReader leer;
        DataTable tablaDepartamentos = new DataTable();

        //Atributos de los datos//
        private int Id;
        private string Departamento;
        private int IdZonaAcceso;
        private int IdUsuario;

        //Funcion GET, SET//
        public int Id1 { get => Id; set => Id = value; }
        public string Departamento1 { get => Departamento; set => Departamento = value; }
        public int IdZonaAcceso1 { get => IdZonaAcceso; set => IdZonaAcceso = value; }
        public int IdUsuario1 { get => IdUsuario; set => IdUsuario = value; }
        //Fin//


        //Funcion para mostrar los datos de la tabla de usuarios: GET//
        public DataTable GetDepartamentos()
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "Sp_GetDepartamentosTabla";
                command.CommandType = CommandType.StoredProcedure;
                leer = command.ExecuteReader();
                tablaDepartamentos.Load(leer);
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
            return tablaDepartamentos;
        }
        //Fin//

    }
}
