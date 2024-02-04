using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace Domain
{
    public class TareasAsignadasModel
    {
        TareasAsignadasCrud actividad = new TareasAsignadasCrud();

        //Funcion para mostrar datos de la tabla de Actividades: GET//
        public DataTable MostrarTablaActividades()
        {
            DataTable tablaActividades = new DataTable();
            tablaActividades = actividad.GetActividades();
            return tablaActividades;
        }
        //Fin//


        //Funcion para mostrar los datos en el combobox//
        public DataTable ListadoUsuarios()
        {
            DataTable tablaActividades = new DataTable();
            tablaActividades = actividad.ListarUsuarios();
            return tablaActividades;
        }
        //Fin//


        //Funcion para filtrar los registros//
        public DataTable MostrarTablaActividadesPorUsuario(int idUsuario)
        {
            DataTable tablaActividades = new DataTable();
            tablaActividades = actividad.GetActividadesPorUsuario(idUsuario);
            return tablaActividades;
        }
        //Fin//

    }
}
