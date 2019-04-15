using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Control_Cementerio
{
    public partial class RecuperarFrom : Form
    {
        public RecuperarFrom()
        {
            InitializeComponent();
        }

        UserModel Model = new UserModel();
        private void btn_enviar_Click(object sender, EventArgs e)
        {
            txt_mensaje.Text = Model.RecuperarEmail(txt_correo.Text);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
