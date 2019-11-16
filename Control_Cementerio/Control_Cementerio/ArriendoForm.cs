﻿using System;
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
            Mostrar_TArriendo();
        }

        private void Mostrar_TArriendo()
        {
            CN_Arriendo obj_C = new CN_Arriendo();
            dataGridView_Arriendo.DataSource = obj_C.Listar_Arriendo();
            dataGridView_Arriendo.Columns[0].HeaderText= "ID";
            dataGridView_Arriendo.Columns[0].FillWeight= 30;
            dataGridView_Arriendo.Columns[1].HeaderText = "NOMBRE CEMENTERIO";
            dataGridView_Arriendo.Columns[1].FillWeight = 200;
            dataGridView_Arriendo.Columns[2].HeaderText = "CATEGORIA";
            dataGridView_Arriendo.Columns[2].FillWeight = 50;
            dataGridView_Arriendo.Columns[3].HeaderText = "AÑO";
            dataGridView_Arriendo.Columns[3].FillWeight = 30;
            dataGridView_Arriendo.Columns[4].HeaderText = "PRECIO";
            dataGridView_Arriendo.Columns[4].FillWeight = 50;
            dataGridView_Arriendo.Columns[5].HeaderText = "IVA";
            dataGridView_Arriendo.Columns[5].FillWeight = 30;
            dataGridView_Arriendo.Columns[6].HeaderText = "TOTAL";
            dataGridView_Arriendo.Columns[6].FillWeight = 50;
        }

        private void btn_editarA_Click(object sender, EventArgs e)
        {
            AgregarAForm frm = new AgregarAForm();
            if (dataGridView_Arriendo.SelectedRows.Count > 0)
            {
                frm.txt_cementerio.Text = dataGridView_Arriendo.CurrentRow.Cells[1].Value.ToString();
                frm.cmb_categoria.Text = dataGridView_Arriendo.CurrentRow.Cells[2].Value.ToString();
                frm.txt_año.Text = dataGridView_Arriendo.CurrentRow.Cells[3].Value.ToString();
                frm.txt_precio.Text = dataGridView_Arriendo.CurrentRow.Cells[4].Value.ToString();
                frm.txt_iva.Text = dataGridView_Arriendo.CurrentRow.Cells[5].Value.ToString();
                frm.txt_total.Text = dataGridView_Arriendo.CurrentRow.Cells[6].Value.ToString();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar la FILA que desea EDITAR");
            }
        }

        private void btn_nuevoA_Click(object sender, EventArgs e)
        {
            AgregarAForm frm = new AgregarAForm();
            AddOwnedForm(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.Controls.Add(frm);
            this.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }
    }
}
