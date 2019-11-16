namespace Control_Cementerio
{
    partial class AgregarAForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cementerio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.txt_año = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_iva = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_enviarA = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "CEMENTERIO:";
            // 
            // txt_cementerio
            // 
            this.txt_cementerio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_cementerio.Location = new System.Drawing.Point(122, 21);
            this.txt_cementerio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cementerio.Name = "txt_cementerio";
            this.txt_cementerio.Size = new System.Drawing.Size(160, 23);
            this.txt_cementerio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "CATEGORIA:";
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Location = new System.Drawing.Point(122, 53);
            this.cmb_categoria.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(160, 24);
            this.cmb_categoria.TabIndex = 5;
            // 
            // txt_año
            // 
            this.txt_año.Location = new System.Drawing.Point(122, 91);
            this.txt_año.Margin = new System.Windows.Forms.Padding(4);
            this.txt_año.Name = "txt_año";
            this.txt_año.ReadOnly = true;
            this.txt_año.Size = new System.Drawing.Size(160, 23);
            this.txt_año.TabIndex = 7;
            this.txt_año.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_año_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "AÑOS:";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(122, 127);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(160, 23);
            this.txt_precio.TabIndex = 9;
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            this.txt_precio.Leave += new System.EventHandler(this.txt_precio_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "PRECIO:";
            // 
            // txt_iva
            // 
            this.txt_iva.Location = new System.Drawing.Point(122, 158);
            this.txt_iva.Margin = new System.Windows.Forms.Padding(4);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.ReadOnly = true;
            this.txt_iva.Size = new System.Drawing.Size(160, 23);
            this.txt_iva.TabIndex = 11;
            this.txt_iva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_iva_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 164);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "IVA:";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(122, 189);
            this.txt_total.Margin = new System.Windows.Forms.Padding(4);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(160, 23);
            this.txt_total.TabIndex = 13;
            this.txt_total.Enter += new System.EventHandler(this.txt_total_Enter);
            this.txt_total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_total_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 195);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "TOTAL:";
            // 
            // btn_enviarA
            // 
            this.btn_enviarA.Location = new System.Drawing.Point(122, 236);
            this.btn_enviarA.Name = "btn_enviarA";
            this.btn_enviarA.Size = new System.Drawing.Size(75, 23);
            this.btn_enviarA.TabIndex = 14;
            this.btn_enviarA.Text = "Enviar";
            this.btn_enviarA.UseVisualStyleBackColor = true;
            this.btn_enviarA.Click += new System.EventHandler(this.btn_enviarA_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(207, 236);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // AgregarAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(313, 281);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_enviarA);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_iva);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_año);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_categoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_cementerio);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AgregarAForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarAForm";
            this.Load += new System.EventHandler(this.AgregarAForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_enviarA;
        public System.Windows.Forms.TextBox txt_cementerio;
        public System.Windows.Forms.ComboBox cmb_categoria;
        public System.Windows.Forms.TextBox txt_año;
        public System.Windows.Forms.TextBox txt_precio;
        public System.Windows.Forms.TextBox txt_iva;
        public System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button btn_cancelar;
    }
}