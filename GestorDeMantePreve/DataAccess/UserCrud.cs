using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class UserCrud: ConnectionToSql
    {
        ConnectionToSql conexion = new ConnectionToSql();
        SqlCommand command = new SqlCommand();
        SqlDataReader leer;
        DataTable tablaUsuarios = new DataTable();

        //Funcion para mostrar los datos de la tabla de usuarios: GET//
        public DataTable GetUsuarios()
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "select * from Usuarios";
                leer = command.ExecuteReader();
                tablaUsuarios.Load(leer);
                
            }
            catch(Exception ex)
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


        //Funcion para agregar datos a la tabla de usuarios: POST//
        public void PostUsuarios(string correo, string pass, string nombres, string apPaterno, string apMaterno)
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "Insert Into Usuarios Values ('" + correo + "', '" + pass + "', '" + nombres + "', '" + apPaterno + "', '" + apMaterno + "')";
                command.ExecuteNonQuery();

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


        //Funcion para realizar modificaciones a los datos de la tabla de usuarios: PUT//
        public void PutUsuarios(string correo, string pass, string nombres, string apPaterno, string apMaterno, int id)
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "UPDATE Usuarios SET Correo = '" + correo + "', Pass= '" + pass + "', Nombres = '" + nombres + "', ApPaterno = '" + apPaterno + "', ApMaterno = '" + apMaterno + "' WHERE Id = " + id;
                command.ExecuteNonQuery();
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


        //Funcion para eliminar registro de la tabla de usuarios: DELETE//
        public void DeleteUsuarios(int id)
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "DELETE FROM Usuarios WHERE Id = @Id";
                command.Parameters.AddWithValue("@Id", id);
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
