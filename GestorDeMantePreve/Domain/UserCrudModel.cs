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
    public class UserCrudModel
    {
        private UserCrud userCrud = new UserCrud();

        //Funciones para listar la informacion de los combobox//
        public DataTable ListadoDepartamentos()
        {
            DataTable tablaUsuarios = new DataTable();
            tablaUsuarios = userCrud.ListarDepartamentos();
            return tablaUsuarios;
        }
        public DataTable ListadoAreas()
        {
            DataTable tablaUsuarios = new DataTable();
            tablaUsuarios = userCrud.ListarAreas();
            return tablaUsuarios;
        }
        public DataTable ListadoPuestos()
        {
            DataTable tablaUsuarios = new DataTable();
            tablaUsuarios = userCrud.ListarPuestos();
            return tablaUsuarios;
        }
        //Fin//

        //Funcion para mostrar los datos de la tabla de Usuarios: GET//
        public DataTable MostrarTablaUsuarios()
        {
            DataTable tablaUsuarios = new DataTable();
            tablaUsuarios = userCrud.GetUsuarios();
            return tablaUsuarios;
        }
        //Fin//

    }
}
