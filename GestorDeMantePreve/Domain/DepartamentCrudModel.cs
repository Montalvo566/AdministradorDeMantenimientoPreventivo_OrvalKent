using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace Domain
{
    public class DepartamentCrudModel
    {
        DepartamentCrud departCrud = new DepartamentCrud();


        //Fuciones encardas de enlistar los datos de las Areas y Equipos//
        public DataTable ListadoAreas()
        {
            DataTable tablaDepartamentos = new DataTable();
            tablaDepartamentos = departCrud.ListarAreas();
            return tablaDepartamentos;
        }
        //Fin//


        //Funcion para mostrar los datos de la tabla de Departamentos: GET//
        public DataTable MostrarTablaDep()
        {
            DataTable tablaDepartamentos = new DataTable();
            tablaDepartamentos = departCrud.GetDepartamentos();
            return tablaDepartamentos;
        }
        //Fin//
    }
}
