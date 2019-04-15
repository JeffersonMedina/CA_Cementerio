namespace Control_Cementerio
{
    partial class PrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.panel_superior = new System.Windows.Forms.Panel();
            this.panel_lateral = new System.Windows.Forms.Panel();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_rol = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_maximizar = new System.Windows.Forms.PictureBox();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.panel_superior.SuspendLayout();
            this.panel_lateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_superior
            // 
            this.panel_superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(218)))), ((int)(((byte)(156)))));
            this.panel_superior.Controls.Add(this.btn_minimizar);
            this.panel_superior.Controls.Add(this.btn_maximizar);
            this.panel_superior.Controls.Add(this.btn_cerrar);
            this.panel_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_superior.Location = new System.Drawing.Point(0, 0);
            this.panel_superior.Name = "panel_superior";
            this.panel_superior.Size = new System.Drawing.Size(800, 30);
            this.panel_superior.TabIndex = 0;
            this.panel_superior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_superior_MouseDown);
            // 
            // panel_lateral
            // 
            this.panel_lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(121)))), ((int)(((byte)(78)))));
            this.panel_lateral.Controls.Add(this.lbl_rol);
            this.panel_lateral.Controls.Add(this.lbl_email);
            this.panel_lateral.Controls.Add(this.lbl_nombre);
            this.panel_lateral.Controls.Add(this.pictureBox1);
            this.panel_lateral.Controls.Add(this.btn_logout);
            this.panel_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_lateral.Location = new System.Drawing.Point(0, 30);
            this.panel_lateral.MaximumSize = new System.Drawing.Size(250, 0);
            this.panel_lateral.MinimumSize = new System.Drawing.Size(250, 0);
            this.panel_lateral.Name = "panel_lateral";
            this.panel_lateral.Size = new System.Drawing.Size(250, 420);
            this.panel_lateral.TabIndex = 1;
            this.panel_lateral.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_lateral_MouseDown);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(76, 13);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(76, 53);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(38, 13);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "Correo";
            // 
            // lbl_rol
            // 
            this.lbl_rol.AutoSize = true;
            this.lbl_rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rol.Location = new System.Drawing.Point(3, 79);
            this.lbl_rol.Name = "lbl_rol";
            this.lbl_rol.Size = new System.Drawing.Size(23, 13);
            this.lbl_rol.TabIndex = 4;
            this.lbl_rol.Text = "Rol";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Control_Cementerio.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_logout
            // 
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_logout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(0, 385);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(250, 35);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "Logut";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(218)))), ((int)(((byte)(156)))));
            this.btn_minimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_minimizar.Image = global::Control_Cementerio.Properties.Resources.minimizar_ventana;
            this.btn_minimizar.Location = new System.Drawing.Point(704, 0);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(32, 30);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 9;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(218)))), ((int)(((byte)(156)))));
            this.btn_maximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_maximizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_maximizar.Image")));
            this.btn_maximizar.Location = new System.Drawing.Point(736, 0);
            this.btn_maximizar.Name = "btn_maximizar";
            this.btn_maximizar.Size = new System.Drawing.Size(32, 30);
            this.btn_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_maximizar.TabIndex = 8;
            this.btn_maximizar.TabStop = false;
            this.btn_maximizar.Click += new System.EventHandler(this.btn_maximizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(218)))), ((int)(((byte)(156)))));
            this.btn_cerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_cerrar.Image = global::Control_Cementerio.Properties.Resources.cerrar_ventana;
            this.btn_cerrar.Location = new System.Drawing.Point(768, 0);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(32, 30);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrar.TabIndex = 7;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_lateral);
            this.Controls.Add(this.panel_superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrincipalForm";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PrincipalForm_MouseDown);
            this.panel_superior.ResumeLayout(false);
            this.panel_lateral.ResumeLayout(false);
            this.panel_lateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_superior;
        private System.Windows.Forms.Panel panel_lateral;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.PictureBox btn_maximizar;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_rol;
    }
}