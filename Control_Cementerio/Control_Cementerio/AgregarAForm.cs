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
    public partial class AgregarAForm : Form
    {
        public AgregarAForm()
        {
            InitializeComponent();
        }

        private void Lista_Cat()
        {
            CN_Arriendo obj_categoria = new CN_Arriendo();
            cmb_categoria.DataSource = obj_categoria.Listar_Categoria();
            cmb_categoria.DisplayMember = "nombre_categoria";
            cmb_categoria.ValueMember = "nombre_categoria";
        }

        private void AgregarAForm_Load(object sender, EventArgs e)
        {
            Lista_Cat();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_enviarA_Click(object sender, EventArgs e)
        {

        }
    }
}
