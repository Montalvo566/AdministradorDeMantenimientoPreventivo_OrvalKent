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

        //Funcion para mostrar los datos de la tabla de Usuarios: GET//
        public DataTable MostrarUsuarios()
        {
            DataTable tablaUsuarios = new DataTable();
            tablaUsuarios = userCrud.GetUsuarios();
            return tablaUsuarios;
        }
        //Fin//


        //Funcion para agregar datos a la tabla de Usuarios: POST//
        public void InsertarUsuarios(string correo, string pass, string nombres, string apPaterno, string apMaterno)
        {
            userCrud.PostUsuarios(correo, pass, nombres, apPaterno, apMaterno);
            //Si quieres convertir datos de tipo int a string puedes usar
            //userCrud.PostUsuarios(Convert.ToDouble(telefono));
        }
        //Fin//


        //Funcion para editar los datos a la tabla de Usuarios: PUT//
        public void ActualizarUsuarios(string correo, string pass, string nombres, string apPaterno, string apMaterno, string id)
        {
            userCrud.PutUsuarios(correo, pass, nombres, apPaterno, apMaterno, Convert.ToInt32(id));
        }
        //Fin//


        //Funcion para eliminar registros de la tabla de usuarios: DELETE//
        public void EliminarUsuarios(string id)
        {
            userCrud.DeleteUsuarios(Convert.ToInt32(id));
        }
        //Fin//

    }
}
