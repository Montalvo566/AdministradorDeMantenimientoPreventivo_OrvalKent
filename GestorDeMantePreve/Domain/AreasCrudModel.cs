using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace Domain
{
    public class AreasCrudModel
    {
        AreasCrud areasCrud = new AreasCrud();

        //Funciones para listar la informacion de los combobox//
        public DataTable ListadoDepartamentos()
        {
            DataTable tablaAreas = new DataTable();
            tablaAreas = areasCrud.ListarDepartamentos();
            return tablaAreas;
        }
        //Fin//


        //Funcion para mostrar los datos de la tabla de Areas: GET//
        public DataTable MostrarTablaAreas()
        {
            DataTable tablaAreas = new DataTable();
            tablaAreas = areasCrud.GetAreas();
            return tablaAreas;
        }
        //Fin//

    }
}
