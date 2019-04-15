using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CD_Arriendo:ConexionBD
    {
        
        MySqlDataReader leer;
        DataTable tabla_arriendo = new DataTable();
        MySqlCommand command = new MySqlCommand();

        public DataTable Mostrar()
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
