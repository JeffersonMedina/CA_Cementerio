using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class UserLoginCache
    {
        public static string Nick { get; set; }
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static string Email { get; set; }
        public static string Password { get; set; }
        public static string Rol { get; set; }
    }

    public static class TablaArriendo
    {
        public static string Cementerio { get; set; }
        public static string Nombre_Categoria { get; set; }
        public static int Tiempo { get; set; }
        public static decimal Valor { get; set; }
        public static int Iva { get; set; }
        public static decimal Total { get; set; }
    }

}
