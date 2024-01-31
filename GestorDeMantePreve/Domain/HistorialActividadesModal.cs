using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace Domain
{
    public class HistorialActividadesModal
    {
        HistorialActividadesCrud historial = new HistorialActividadesCrud();

        //Funcion para mostrar la tabla del historial//
        public DataTable MostrarHistorialActividades()
        {
            DataTable tablaHistorial = new DataTable();
            tablaHistorial = historial.GetHistorialActividades();
            return tablaHistorial;
        }
        //Fin//
    }
}
