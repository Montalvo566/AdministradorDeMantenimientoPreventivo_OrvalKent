using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;

namespace DataAccess
{
    public class UserDao:ConnectionToSql
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Usuarios where Correo=@user and Pass=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        //Metodo para obtener los datos del usuario//
                        while (reader.Read())
                        {
                            //Se coloca el dato que se quiere obtener, el tipo de dato y su posicion en la base de datos, siempre se comienza en cero
                            UserLoginCache.Id = reader.GetInt32(0);
                            UserLoginCache.Correo = reader.GetString(1);
                            UserLoginCache.Nombres = reader.GetString(3);
                        }
                        //Fin//
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
        }
    }
}
