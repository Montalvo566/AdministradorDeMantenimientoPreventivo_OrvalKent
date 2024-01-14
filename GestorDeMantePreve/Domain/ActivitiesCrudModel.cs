using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DataAccess;

namespace Domain
{
    public class ActivitiesCrudModel
    {
        ActivitiesCrud actividad = new ActivitiesCrud();

        //Fuciones encardas de enlistar los datos de las Areas y Equipos//
        public DataTable ListadoAreas()
        {
            DataTable tablaActividades = new DataTable();
            tablaActividades = actividad.ListarAreas();
            return tablaActividades;
        }
        public DataTable ListadoEquipos()
        {
            DataTable tablaActividades = new DataTable();
            tablaActividades = actividad.ListarEquipos();
            return tablaActividades;
        }
        public DataTable ListadoFrecuencias()
        {
            DataTable tablaActividades = new DataTable();
            tablaActividades = actividad.ListarFrecuencias();
            return tablaActividades;
        }
        public DataTable ListadoUsuarioRegistra()
        {
            DataTable tablaActividades = new DataTable();
            tablaActividades = actividad.ListarUsuariosRegistra();
            return tablaActividades;
        }
        public DataTable ListadoUsuarioAsignado()
        {
            DataTable tablaActividades = new DataTable();
            tablaActividades = actividad.ListarUsuarioAsignado();
            return tablaActividades;
        }
        //Fin//


        //Funcion para mostrar datos de la tabla de Actividades: GET
        public DataTable MostrarTablaActividades()
        {
            DataTable tablaActividades = new DataTable();
            tablaActividades = actividad.GetActividades();
            return tablaActividades;
        }
        //Fin//
    }
}
