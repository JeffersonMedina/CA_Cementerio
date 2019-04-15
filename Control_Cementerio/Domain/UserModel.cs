using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Common.Cache;

namespace Domain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();
        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }
        public string RecuperarEmail(string email)
        {
            string mensaje;
            mensaje = userDao.RecuperarContraseña(email);
            return mensaje;
        }
    }
}
