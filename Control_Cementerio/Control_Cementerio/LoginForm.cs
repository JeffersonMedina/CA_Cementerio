using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Domain;

namespace Control_Cementerio
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnnd, int wmsg, int wparam, int lparam);

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pct_municipio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            lbl_ErrorMessage.Visible = false;
            if (txt_usuario.Text != "" && txt_password.Text != "")
            {
                UserModel user = new UserModel();
                var validLogin = user.LoginUser(txt_usuario.Text, txt_password.Text);
                if (validLogin == true)
                {
                    PrincipalForm mainMenu = new PrincipalForm();
                    mainMenu.Show();
                    mainMenu.FormClosed += logout;
                    this.Hide();
                }
                else
                {
                    MsgError("Incorrecto Usuario o Contraseña.");
                    txt_usuario.Clear();
                    txt_password.Clear();
                    txt_usuario.Focus();
                }
            }
            else { MsgError("Ingrese nombre de Usuario."); }
        }
        private void MsgError(string msg)
        {
            lbl_ErrorMessage.Text = "         " + msg;
            lbl_ErrorMessage.Visible = true;
        }
        private void logout(object sender, FormClosedEventArgs e)
        {
            txt_usuario.Clear();
            txt_password.Clear();
            lbl_ErrorMessage.Visible = false;
            this.Show();
            txt_usuario.Focus();
        }

        private void link_contraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarFrom recuperar = new RecuperarFrom();
            recuperar.ShowDialog();
        }
    }
}
