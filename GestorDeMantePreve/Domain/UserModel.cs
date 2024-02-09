using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data.SqlClient;
using System.Data;

namespace Domain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();

        //Funcion para iniciar sesion//
        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }
        //Fin//


        //Funcion para mostrar las actividades asignadas a cada usuario//
        public DataTable MostrarTablaActividades(int numeroEmpleado)
        {
            DataTable tablaUsuarios = new DataTable();
            tablaUsuarios = userDao.GetActividades(numeroEmpleado);
            return tablaUsuarios;
        }
        //Fin//
    }
}
