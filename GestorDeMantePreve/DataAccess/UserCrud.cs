using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace DataAccess
{
    public class UserCrud: ConnectionToSql
    {
        ConnectionToSql conexion = new ConnectionToSql();
        SqlCommand command = new SqlCommand();
        SqlDataReader leer;
        DataTable tablaUsuarios = new DataTable();

        //Atributos de los datos//
        private int Id;
        private string NombreCompleto;
        private int NumeroTrabajador;
        private int Departamento;
        private int Area;
        private int Puesto;
        private string Correo;
        private string Contrasena;
        private string Foto;

        //Funcion GET, SET
        public int Id1 { get => Id; set => Id = value; }
        public string NombreCompleto1 { get => NombreCompleto; set => NombreCompleto = value; }
        public int NumeroTrabajador1 { get => NumeroTrabajador; set => NumeroTrabajador = value; }
        public int Departamento1 { get => Departamento; set => Departamento = value; }
        public int Area1 { get => Area; set => Area = value; }
        public int Puesto1 { get => Puesto; set => Puesto = value; }
        public string Correo1 { get => Correo; set => Correo = value; }
        public string Contrasena1 { get => Contrasena; set => Contrasena = value; }
        public string Foto1 { get => Foto; set => Foto = value; }
        //Fin//

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
        public void PostUsuarios()
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
        public void PutUsuarios()
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "Sp_UsuariosPUT";
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
                command.Parameters.AddWithValue("@Id", Id);
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


        //Funcion para eliminar registro de la tabla de usuarios: DELETE//
        public void DeleteUsuarios(string fotoPath)
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "Sp_UsuariosDELETE";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", Id);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
                if (File.Exists(fotoPath))
                {
                    File.Delete(fotoPath);
                }
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
