using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Common.Configuracion;

namespace Control_Cementerio
{
    public partial class AgregarAForm : Form
    {
        public AgregarAForm()
        {
            InitializeComponent();
            
        }

        CN_Arriendo obj_categoria = new CN_Arriendo();

        private void Lista_Cat()
        {            
            cmb_categoria.DataSource = obj_categoria.Listar_Categoria();
            cmb_categoria.DisplayMember = "nombre_categoria";
            cmb_categoria.ValueMember = "nombre_categoria";
        }

        private void AgregarAForm_Load(object sender, EventArgs e)
        {
            Lista_Cat();
            txt_año.Text = DataConfig.AÑOS;
            txt_iva.Text = DataConfig.IVA;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_enviarA_Click(object sender, EventArgs e)
        {
            try
            {
                obj_categoria.Insertar_Arriendo(txt_cementerio.Text, cmb_categoria.SelectedValue.ToString(), txt_año.Text, txt_precio.Text, txt_iva.Text, txt_total.Text);
                this.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo guardar ERROR: "+ ex);
            }
            
        }

        private void txt_año_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj_categoria.SoloNumeros(e);
        }

        private void txt_iva_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj_categoria.SoloNumeros(e);
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj_categoria.Num_Decimal(e);
        }

        private void txt_total_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj_categoria.Num_Decimal(e);
        }

        private void txt_precio_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal d = Convert.ToDecimal(txt_precio.Text);
                txt_precio.Text = string.Format("{0:n}", d);
            }catch(Exception ex)
            {
                Console.Write("ERROR: " + ex);
            }
            
        }

        private void txt_total_Enter(object sender, EventArgs e)
        {
            try
            {
                decimal num1 = Convert.ToDecimal(txt_precio.Text);
                decimal num2 = Convert.ToDecimal(txt_iva.Text);
                decimal subtotal = (num1 * num2) / 100;
                decimal total = num1 + subtotal;

                txt_total.Text = string.Format("{0:n}", total);
            }catch(Exception ex)
            {
                Console.Write("ERROR: " + ex);
            }
            

        }
    }
}
