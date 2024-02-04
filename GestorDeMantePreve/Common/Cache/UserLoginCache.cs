using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class UserLoginCache
    {
        //Se extraen los datos que se quieren mostrar del usuario
        public static int Id { get; set; }
        public static string Correo { get; set; }
        public static string NombreCompleto { get; set; }
        public static int Puesto { get; set; }
        public static string Foto { get; set; }
    }

}
