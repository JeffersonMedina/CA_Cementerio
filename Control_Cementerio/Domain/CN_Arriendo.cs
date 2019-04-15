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
        private CD_Arriendo obj_CD = new DataAccess.CD_Arriendo();

        public DataTable Mostrar_Arriendo()
        {
            DataTable tabla_MA = new DataTable();
            tabla_MA = obj_CD.Mostrar();
            return tabla_MA;
        }
    }
}
