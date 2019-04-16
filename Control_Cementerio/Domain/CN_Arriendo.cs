using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using DataAccess;
using System.Data;

namespace Domain
{
    public class CN_Arriendo
    {
        private CD_Listar obj_CD = new DataAccess.CD_Listar();

        public DataTable Listar_Arriendo()
        {
            DataTable tabla_MA = new DataTable();
            tabla_MA = obj_CD.Lista_Arriendo();
            return tabla_MA;
        }

        public DataTable Listar_Categoria()
        {
            DataTable tabla_MC = new DataTable();
            tabla_MC = obj_CD.Lista_Categoria();
            return tabla_MC;
        }
    }
}
