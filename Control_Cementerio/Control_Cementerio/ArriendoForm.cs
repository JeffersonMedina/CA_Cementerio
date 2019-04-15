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
    public partial class ArriendoForm : Form
    {
        CN_Arriendo obj_CN = new CN_Arriendo();
        public ArriendoForm()
        {
            InitializeComponent();
        }

        private void ArriendoForm_Load(object sender, EventArgs e)
        {
            Mostrar_Arriendo();
        }

        private void Mostrar_Arriendo()
        {
            dataGridView1.DataSource = obj_CN.Mostrar_Arriendo();
        }
    }
}
