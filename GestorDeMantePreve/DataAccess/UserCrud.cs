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

        //Funciones pra listar las opciones del combobox: Departamento, Area y Puesto//
        public DataTable ListarDepartamentos()
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "sp_ListarDepartamentos";
                command.CommandType = CommandType.StoredProcedure;
                leer = command.ExecuteReader();
                tablaUsuarios.Load(leer);
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
            return tablaUsuarios;
        }

        public DataTable ListarAreas()
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "sp_ListarAreas";
                command.CommandType = CommandType.StoredProcedure;
                leer = command.ExecuteReader();
                tablaUsuarios.Load(leer);
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
            return tablaUsuarios;
        }

        public DataTable ListarPuestos()
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "sp_ListarPuestos";
                command.CommandType = CommandType.StoredProcedure;
                leer = command.ExecuteReader();
                tablaUsuarios.Load(leer);
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
            return tablaUsuarios;
        }
        //Fin//

        //Funcion para mostrar los datos de la tabla de usuarios: GET//
        public DataTable GetUsuarios()
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "Sp_GetUsuariosTabla";
                command.CommandType = CommandType.StoredProcedure;
                leer = command.ExecuteReader();
                tablaUsuarios.Load(leer);
                leer.Close();
                
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
        public void PostUsuarios(string NombreCompleto, int NumeroTrabajador, int Departamento,
            int Area, int Puesto, string Correo, string Contrasena, string Foto)
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "Sp_UsuariosPOST";
                command.CommandType = CommandType.StoredProcedure;
                //Parametros de entrada//
                command.Parameters.AddWithValue("@NombreCompleto", NombreCompleto);
                command.Parameters.AddWithValue("@NumeroEmpleado", NumeroTrabajador);
                command.Parameters.AddWithValue("@IdDepartamento", Departamento);
                command.Parameters.AddWithValue("@IdZonaAcceso", Area);
                command.Parameters.AddWithValue("@IdPuesto", Puesto);
                command.Parameters.AddWithValue("@Correo ", Correo);
                command.Parameters.AddWithValue("@Contrasena", Contrasena);
                command.Parameters.AddWithValue("@Foto", Foto);
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
