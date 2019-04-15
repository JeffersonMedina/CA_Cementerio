namespace Control_Cementerio
{
    partial class RecuperarFrom
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 37);
            this.panel1.TabIndex = 0;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_cerrar.Image = global::Control_Cementerio.Properties.Resources.cerrar_ventana;
            this.btn_cerrar.Location = new System.Drawing.Point(510, 0);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(43, 37);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrar.TabIndex = 8;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese Correo:";
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(124, 54);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(274, 23);
            this.txt_correo.TabIndex = 1;
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(436, 47);
            this.btn_enviar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(100, 28);
            this.btn_enviar.TabIndex = 2;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_mensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mensaje.Location = new System.Drawing.Point(124, 83);
            this.txt_mensaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_mensaje.Multiline = true;
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.ReadOnly = true;
            this.txt_mensaje.Size = new System.Drawing.Size(365, 86);
            this.txt_mensaje.TabIndex = 3;
            // 
            // RecuperarFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(553, 185);
            this.Controls.Add(this.txt_mensaje);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RecuperarFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecuperarFrom";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.TextBox txt_mensaje;
    }
}