using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public class UserDao:ConexionBD
    {
        public bool Login(string user, string pass)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = Get_Conectar();
            command.CommandText = "SELECT * FROM usuario WHERE nick=@user AND password=@pass;";
            command.Parameters.AddWithValue("@user", user);
            command.Parameters.AddWithValue("@pass", pass);
            Abrir_Conexion();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                Cerrar_Conexion();
                return true;
            }
            else
            {
                Cerrar_Conexion();
                return false;
            }
        }
    }
}
