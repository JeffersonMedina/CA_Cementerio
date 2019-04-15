using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;

namespace Control_Cementerio
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnnd, int wmsg, int wparam, int lparam);

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar la aplicación?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar Sesión?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void panel_superior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel_lateral_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PrincipalForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LoadData()
        {
            lbl_nombre.Text = UserLoginCache.Nombre + "\n" + UserLoginCache.Apellido;
            lbl_email.Text = UserLoginCache.Email;
            lbl_rol.Text = UserLoginCache.Rol;
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Abrir_FormHijo(object formhijjo)
        {
            if(panel_contenedor.Controls.Count > 0)
            {
                this.panel_contenedor.Controls.RemoveAt(0);
            }
            Form fh = formhijjo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(fh);
            this.panel_contenedor.Tag = fh;
            fh.Show();
        }

        private void btn_arriendo_Click(object sender, EventArgs e)
        {
            Abrir_FormHijo(new ArriendoForm());
        }
    }
}
