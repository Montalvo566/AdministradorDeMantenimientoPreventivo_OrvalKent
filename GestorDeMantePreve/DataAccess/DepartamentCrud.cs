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

        //Funcion GET, SET//
        public int Id1 { get => Id; set => Id = value; }
        public string Departamento1 { get => Departamento; set => Departamento = value; }
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


        //Funcion para agregar datos a la tabla de departamentos: POST//
        public void PostDepartamentos()
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "Sp_DepartamentosPOST";
                command.CommandType = CommandType.StoredProcedure;
                //Parametros de entrada//
                command.Parameters.AddWithValue("@Departamento", Departamento);
                //Fin//
                command.ExecuteReader();
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


        //Funcion para actualizar datos a la tabla de Departamentos: PUT//
        public void PutDepartamentos()
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "Sp_DepartamentosPUT";
                command.CommandType = CommandType.StoredProcedure;
                //Parametros de entrada//
                command.Parameters.AddWithValue("@Departamento", Departamento);
                command.Parameters.AddWithValue("@Id", Id);
                //Fin//
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


        //Funcion para eliminar registro de la tabla de departamentos: DELETE//
        public void DeleteDepartamentos()
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "Sp_DepartamentosDELETE";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", Id);
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
