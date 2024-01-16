using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace Domain
{
    public class EquiposCrudModel
    {
        EquiposCrud equiposCrud = new EquiposCrud();

        //Fuciones encardas de enlistar los datos de las Areas y Equipos//
        public DataTable ListadoAreas()
        {
            DataTable tablaEquipos = new DataTable();
            tablaEquipos = equiposCrud.ListarAreas();
            return tablaEquipos;
        }
        //Fin//


        //Funcion para mostrar los datos de la tabla de Equipos: GET//
        public DataTable MostrarTablaEquipos()
        {
            DataTable tablaEquipos = new DataTable();
            tablaEquipos = equiposCrud.GetEquipos();
            return tablaEquipos;
        }
        //Fin//
    }
}
