using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data.SqlClient;
using System.Data;
using Common.Cache;

namespace Domain
{
    public class HistorialDomain
    {
        HistorialDataAccess userDao = new HistorialDataAccess();

        //Funcion para mostrar la tabla del historial//
        public DataTable MostrarHistorialActividades()
        {
            DataTable tablaHistorial = new DataTable();
            tablaHistorial = userDao.GetHistorialActividades();
            return tablaHistorial;
        }
        //Fin//


        //Funcion para obtener el puesto del empleado//
        public int ObtenerPuestoPorNumeroEmpleado(int numeroEmpleado)
        {
            try
            {
                HistorialDataAccess userDao = new HistorialDataAccess();
                int puesto = userDao.ObtenerPuestoPorNumeroEmpleado(numeroEmpleado);

                Console.WriteLine("Puesto obtenido en HistorialDomain: " + puesto);

                return puesto;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el puesto en HistorialDomain: " + ex.Message);
                return 0;
            }
        }
        //Fin//


        //Funcion para registrar el historial y cambiar el estado a terminado
        public void RegistrarEnHistorialEnRevision()
        {
            userDao.RegistrarEnHistorialEnRevision();
        }
        //Fin//
    }
}
