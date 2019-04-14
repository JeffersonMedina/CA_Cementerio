using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace DataAccess
{
    public class ConexionBD
    {
        public MySqlConnection conex;
        string cadenaConexion;


        public MySqlConnection Get_Conectar()
        {
            cadenaConexion = "server=localhost;user id=root;password=root;persistsecurityinfo=True;database=cementerio";
            conex = new MySqlConnection(cadenaConexion);
            return conex;
        }

        protected void Abrir_Conexion()
        {
            conex.Open();
        }

        protected void Cerrar_Conexion()
        {
            conex.Close();
        }
    }
}
