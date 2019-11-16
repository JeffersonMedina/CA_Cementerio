using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using DataAccess;
using System.Data;
using System.Windows.Forms;
using System.Globalization;
using Common.Cache;
using System.Threading;

namespace Domain
{
    public class CN_Arriendo
    {
        private CD_Listar obj_CD = new CD_Listar();
        private CD_CRUD obj_CRUD = new CD_CRUD();

        public DataTable Listar_Arriendo()
        {
            DataTable tabla_MA = new DataTable();
            tabla_MA = obj_CD.Tabla_Arriendo();
            return tabla_MA;
        }

        public DataTable Listar_Categoria()
        {
            DataTable tabla_MC = new DataTable();
            tabla_MC = obj_CD.Tabla_Categoria();
            return tabla_MC;
        }

        public void SoloNumeros(KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        public void Num_Decimal(KeyPressEventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-ES");
            Console.WriteLine("Current culture changed to {0}",Thread.CurrentThread.CurrentCulture.Name);
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void Insertar_Arriendo(string cementerio,string nombre_categoria,string tiempo,string valor,string iva,string total)
        {
            TablaArriendo.Cementerio = cementerio;
            TablaArriendo.Nombre_Categoria = nombre_categoria;
            TablaArriendo.Tiempo = Convert.ToInt32(tiempo);
            TablaArriendo.Valor = Convert.ToDecimal(valor);
            TablaArriendo.Iva = Convert.ToInt32(iva);
            TablaArriendo.Total = Convert.ToDecimal(total);
            obj_CRUD.Insertar_Arriendo(TablaArriendo.Cementerio, TablaArriendo.Nombre_Categoria,TablaArriendo.Tiempo, TablaArriendo.Valor, TablaArriendo.Iva, TablaArriendo.Total);
        }
    }
}
