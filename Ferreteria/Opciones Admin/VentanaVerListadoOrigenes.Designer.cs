namespace Ferreteria.Opciones_Admin
{
    partial class VentanaVerListadoOrigenes
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.articulos = new System.Windows.Forms.DataGridView();
            this.comboOrigen = new System.Windows.Forms.ComboBox();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.registrarOrigen = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.denominacion = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articulos)).BeginInit();
            this.panelDatos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.articulos);
            this.panel3.Controls.Add(this.comboOrigen);
            this.panel3.Location = new System.Drawing.Point(9, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(353, 493);
            this.panel3.TabIndex = 30;
            // 
            // articulos
            // 
            this.articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articulos.Location = new System.Drawing.Point(7, 75);
            this.articulos.Name = "articulos";
            this.articulos.RowHeadersWidth = 51;
            this.articulos.RowTemplate.Height = 24;
            this.articulos.Size = new System.Drawing.Size(338, 406);
            this.articulos.TabIndex = 21;
            // 
            // comboOrigen
            // 
            this.comboOrigen.FormattingEnabled = true;
            this.comboOrigen.Location = new System.Drawing.Point(67, 23);
            this.comboOrigen.Name = "comboOrigen";
            this.comboOrigen.Size = new System.Drawing.Size(266, 24);
            this.comboOrigen.TabIndex = 20;
            // 
            // panelDatos
            // 
            this.panelDatos.Controls.Add(this.label4);
            this.panelDatos.Controls.Add(this.label3);
            this.panelDatos.Controls.Add(this.registrarOrigen);
            this.panelDatos.Controls.Add(this.limpiar);
            this.panelDatos.Controls.Add(this.descripcion);
            this.panelDatos.Controls.Add(this.denominacion);
            this.panelDatos.Location = new System.Drawing.Point(368, 76);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(305, 493);
            this.panelDatos.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(28, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(28, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Denominacion";
            // 
            // registrarOrigen
            // 
            this.registrarOrigen.Location = new System.Drawing.Point(131, 333);
            this.registrarOrigen.Name = "registrarOrigen";
            this.registrarOrigen.Size = new System.Drawing.Size(142, 23);
            this.registrarOrigen.TabIndex = 12;
            this.registrarOrigen.Text = "Registrar origen";
            this.registrarOrigen.UseVisualStyleBackColor = true;
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(50, 333);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 11;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            // 
            // descripcion
            // 
            this.descripcion.Enabled = false;
            this.descripcion.Location = new System.Drawing.Point(28, 223);
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(245, 84);
            this.descripcion.TabIndex = 3;
            // 
            // denominacion
            // 
            this.denominacion.Enabled = false;
            this.denominacion.Location = new System.Drawing.Point(28, 158);
            this.denominacion.Name = "denominacion";
            this.denominacion.Size = new System.Drawing.Size(245, 22);
            this.denominacion.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(-3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 65);
            this.panel1.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(213, 29);
            this.label12.TabIndex = 0;
            this.label12.Text = "Listado Origenes";
            // 
            // VentanaVerListadoOrigenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 575);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.panel1);
            this.Name = "VentanaVerListadoOrigenes";
            this.Text = "VentanaVerListadoOrigenes";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.articulos)).EndInit();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView articulos;
        private System.Windows.Forms.ComboBox comboOrigen;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registrarOrigen;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.TextBox denominacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
    }
}