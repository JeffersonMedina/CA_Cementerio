using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CD_Listar:ConexionBD
    {

        MySqlDataReader leer;
        DataTable tabla_arriendo = new DataTable();
        MySqlCommand command = new MySqlCommand();

        public DataTable Tabla_Categoria()
        {
            command.Connection = Get_Conectar();
            command.CommandText = "SELECT * FROM categoria;";
            Abrir_Conexion();
            leer = command.ExecuteReader();
            tabla_arriendo.Load(leer);
            Cerrar_Conexion();
            return tabla_arriendo;
        }
        public DataTable Tabla_Arriendo()
        {
            command.Connection = Get_Conectar();
            command.CommandText = "SELECT * FROM arriendo;";
            Abrir_Conexion();
            leer = command.ExecuteReader();
            tabla_arriendo.Load(leer);
            Cerrar_Conexion();
            return tabla_arriendo;
        }
    }
}
