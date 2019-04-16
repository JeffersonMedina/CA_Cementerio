namespace Control_Cementerio
{
    partial class ArriendoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_eliminarA = new System.Windows.Forms.Button();
            this.btn_editarA = new System.Windows.Forms.Button();
            this.btn_nuevoA = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView_Arriendo = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Arriendo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 87);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_eliminarA);
            this.panel2.Controls.Add(this.btn_editarA);
            this.panel2.Controls.Add(this.btn_nuevoA);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 335);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 70);
            this.panel2.TabIndex = 4;
            // 
            // btn_eliminarA
            // 
            this.btn_eliminarA.Location = new System.Drawing.Point(174, 28);
            this.btn_eliminarA.Name = "btn_eliminarA";
            this.btn_eliminarA.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminarA.TabIndex = 5;
            this.btn_eliminarA.Text = "Eliminar";
            this.btn_eliminarA.UseVisualStyleBackColor = true;
            // 
            // btn_editarA
            // 
            this.btn_editarA.Location = new System.Drawing.Point(93, 28);
            this.btn_editarA.Name = "btn_editarA";
            this.btn_editarA.Size = new System.Drawing.Size(75, 23);
            this.btn_editarA.TabIndex = 4;
            this.btn_editarA.Text = "Editar";
            this.btn_editarA.UseVisualStyleBackColor = true;
            this.btn_editarA.Click += new System.EventHandler(this.btn_editarA_Click);
            // 
            // btn_nuevoA
            // 
            this.btn_nuevoA.Location = new System.Drawing.Point(12, 28);
            this.btn_nuevoA.Name = "btn_nuevoA";
            this.btn_nuevoA.Size = new System.Drawing.Size(75, 23);
            this.btn_nuevoA.TabIndex = 3;
            this.btn_nuevoA.Text = "Nuevo";
            this.btn_nuevoA.UseVisualStyleBackColor = true;
            this.btn_nuevoA.Click += new System.EventHandler(this.btn_nuevoA_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView_Arriendo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 248);
            this.panel3.TabIndex = 5;
            // 
            // dataGridView_Arriendo
            // 
            this.dataGridView_Arriendo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Arriendo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Arriendo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dataGridView_Arriendo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Arriendo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Arriendo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Arriendo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Arriendo.EnableHeadersVisualStyles = false;
            this.dataGridView_Arriendo.GridColor = System.Drawing.Color.DimGray;
            this.dataGridView_Arriendo.Location = new System.Drawing.Point(12, 24);
            this.dataGridView_Arriendo.Name = "dataGridView_Arriendo";
            this.dataGridView_Arriendo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_Arriendo.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Arriendo.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Arriendo.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Arriendo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Arriendo.Size = new System.Drawing.Size(976, 199);
            this.dataGridView_Arriendo.TabIndex = 1;
            // 
            // ArriendoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1000, 405);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ArriendoForm";
            this.Text = "ArriendoForm";
            this.Load += new System.EventHandler(this.ArriendoForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Arriendo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_editarA;
        private System.Windows.Forms.Button btn_nuevoA;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView_Arriendo;
        private System.Windows.Forms.Button btn_eliminarA;
    }
}