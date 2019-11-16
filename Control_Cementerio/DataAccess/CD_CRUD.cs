using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public class CD_CRUD:ConexionBD
    {
        MySqlCommand command = new MySqlCommand();
        public void Insertar_Arriendo(string cementerio, string categoria, int año, decimal precio, int iva, decimal total)
        {
            command.Connection = Get_Conectar();
            command.CommandText = "INSERT INTO arriendo(cementerio, nombre_categoria, tiempo, valor, IVA, TOTAL)" +
                " values(@cementerio, @nombre_categoria, @tiempo, @valor, @IVA, @TOTAL);";
            command.Parameters.AddWithValue("@cementerio", cementerio);
            command.Parameters.AddWithValue("@nombre_categoria", categoria);
            command.Parameters.AddWithValue("@tiempo", año);
            command.Parameters.AddWithValue("@valor", precio);
            command.Parameters.AddWithValue("@IVA", iva);
            command.Parameters.AddWithValue("@TOTAL", total);
            Abrir_Conexion();
            command.ExecuteNonQuery();
        }
    }
}
