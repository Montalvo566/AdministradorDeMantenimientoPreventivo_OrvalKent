using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class ActivitiesCrud
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
        private string HoraAsignado;

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
        public string HoraAsignado1 { get => HoraAsignado; set => HoraAsignado = value; }
        public int Id1 { get => Id; set => Id = value; }

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

        public DataTable ListarEquipos()
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "Sp_ListarEquipos";
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

        public DataTable ListarFrecuencias()
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "Sp_ListarFrecuencias";
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

        public DataTable ListarUsuariosRegistra()
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

        public DataTable ListarUsuarioAsignado()
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

        public DataTable ListarEstatus()
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "Sp_ListarEstatus";
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


        //Funcion para mostrar los datos en la tabla de Actividades: GET//
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


        //Funcion para insertar datos a la tabla de Actividades: POST//
        public void PostActividades()
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "Sp_ActividadesPOST";
                command.CommandType = CommandType.StoredProcedure;
                //Parametros de entrada//
                command.Parameters.AddWithValue("@IdArea", IdArea);
                command.Parameters.AddWithValue("@IdEquipo", IdEquipo);
                command.Parameters.AddWithValue("@IdFrecuencia", IdFrecuencia);
                command.Parameters.AddWithValue("@Actividad", Actividad);
                command.Parameters.AddWithValue("@Registro", Registro);
                command.Parameters.AddWithValue("@IdUsuarioRegistra", IdUsuarioRegistra);
                command.Parameters.AddWithValue("@IdUsuarioAsignado", IdUsuarioAsignado);
                command.Parameters.AddWithValue("@FechaAsignado", FechaAsignado);
                command.Parameters.AddWithValue("@HoraAsignado", HoraAsignado);
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


        //Funcion para insertar datos a la tabla de Actividades: PUT//
        public void PutActividades()
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "Sp_ActividadesPUT";
                command.CommandType = CommandType.StoredProcedure;
                //Parametros de entrada//
                command.Parameters.AddWithValue("@IdArea", IdArea);
                command.Parameters.AddWithValue("@IdEquipo", IdEquipo);
                command.Parameters.AddWithValue("@IdFrecuencia", IdFrecuencia);
                command.Parameters.AddWithValue("@Actividad", Actividad);
                command.Parameters.AddWithValue("@Registro", Registro);
                command.Parameters.AddWithValue("@Estatus", Estatus);
                command.Parameters.AddWithValue("@IdUsuarioRegistra", IdUsuarioRegistra);
                command.Parameters.AddWithValue("@IdUsuarioAsignado", IdUsuarioAsignado);
                command.Parameters.AddWithValue("@FechaAsignado", FechaAsignado);
                command.Parameters.AddWithValue("@HoraAsignado", HoraAsignado);
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


        //Funcion para eliminar datos de la tabla de Actividades: DELETE//
        public void DeleteActividades()
        {
            try
            {
                command.Connection = conexion.AbrirConexion();
                command.CommandText = "Sp_ActividadesDELETE";
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
