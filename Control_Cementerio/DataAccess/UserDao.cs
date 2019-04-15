using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using Common.Cache;
using System.Net;
using System.Net.Mail;

namespace DataAccess
{
    public class UserDao:ConexionBD
    {
        private string NombreR, EmailR, ContraseñaR, Mensaje;
        public string RecuperarContraseña(string email)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = Get_Conectar();
            command.CommandText = "SELECT * FROM usuario WHERE email=@email;";
            command.Parameters.AddWithValue("@email", email);
            Abrir_Conexion();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read() == true)
            {
                NombreR = reader["nombre"].ToString() + " " + reader["apellido"].ToString();
                EmailR = reader["email"].ToString();
                ContraseñaR = reader["password"].ToString();

                EnviarMail();

                Mensaje = "Estimado " + NombreR + ".Se ha enviado su contraseña a su correo: "+EmailR;
            }
            else
            {
                Mensaje = "No se ha encontrado datos asociados a este correo "+email;
            }
            return Mensaje;
        }
        public void EnviarMail()
        {
            MailMessage Correo = new MailMessage();
            Correo.From = new MailAddress("prueba0zenti@gmail.com");
            Correo.To.Add(EmailR);
            Correo.Subject = ("RECUPERAR CONTRASEÑA SYSTEM");
            Correo.Body = "HOLA " + NombreR + ", USTED SOLICITO RECUPERAR SU CONTRASEÑA. SU CONTRASE ES.\n" + ContraseñaR;
            Correo.Priority = MailPriority.Normal;

            SmtpClient ServerMail = new SmtpClient();
            ServerMail.Credentials = new NetworkCredential("prueba0zenti@gmail.com", "@zenti123");
            ServerMail.Host = "smtp.gmail.com";
            ServerMail.Port = 587;
            ServerMail.EnableSsl = true;
            try
            {
                ServerMail.Send(Correo);
            }catch(Exception e)
            {
                Console.Write("Error mail: " + e);
            }
            Correo.Dispose(); 
        }

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
                while (reader.Read())
                {
                    UserLoginCache.Nick = reader.GetString(1);
                    UserLoginCache.Nombre = reader.GetString(2);
                    UserLoginCache.Apellido = reader.GetString(3);
                    UserLoginCache.Email = reader.GetString(4);
                    UserLoginCache.Password = reader.GetString(5);
                    UserLoginCache.Rol = reader.GetString(6);
                }
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
