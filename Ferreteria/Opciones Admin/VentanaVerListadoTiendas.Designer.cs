namespace Ferreteria.Opciones_Admin
{
    partial class VentanaVerListadoTiendas
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
            this.tiendas = new System.Windows.Forms.DataGridView();
            this.comboTiendas = new System.Windows.Forms.ComboBox();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.comboResponsable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.registrarTienda = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.direccion = new System.Windows.Forms.TextBox();
            this.denominacion = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiendas)).BeginInit();
            this.panelDatos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tiendas);
            this.panel3.Controls.Add(this.comboTiendas);
            this.panel3.Location = new System.Drawing.Point(6, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(619, 542);
            this.panel3.TabIndex = 33;
            // 
            // tiendas
            // 
            this.tiendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tiendas.Location = new System.Drawing.Point(7, 75);
            this.tiendas.Name = "tiendas";
            this.tiendas.RowHeadersWidth = 51;
            this.tiendas.RowTemplate.Height = 24;
            this.tiendas.Size = new System.Drawing.Size(596, 406);
            this.tiendas.TabIndex = 21;
            // 
            // comboTiendas
            // 
            this.comboTiendas.FormattingEnabled = true;
            this.comboTiendas.Location = new System.Drawing.Point(67, 23);
            this.comboTiendas.Name = "comboTiendas";
            this.comboTiendas.Size = new System.Drawing.Size(266, 24);
            this.comboTiendas.TabIndex = 20;
            // 
            // panelDatos
            // 
            this.panelDatos.Controls.Add(this.comboResponsable);
            this.panelDatos.Controls.Add(this.label1);
            this.panelDatos.Controls.Add(this.label4);
            this.panelDatos.Controls.Add(this.label3);
            this.panelDatos.Controls.Add(this.registrarTienda);
            this.panelDatos.Controls.Add(this.limpiar);
            this.panelDatos.Controls.Add(this.direccion);
            this.panelDatos.Controls.Add(this.denominacion);
            this.panelDatos.Location = new System.Drawing.Point(631, 73);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(305, 542);
            this.panelDatos.TabIndex = 32;
            // 
            // comboResponsable
            // 
            this.comboResponsable.FormattingEnabled = true;
            this.comboResponsable.Location = new System.Drawing.Point(31, 358);
            this.comboResponsable.Name = "comboResponsable";
            this.comboResponsable.Size = new System.Drawing.Size(242, 24);
            this.comboResponsable.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Responsable";
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
            // registrarTienda
            // 
            this.registrarTienda.Location = new System.Drawing.Point(131, 398);
            this.registrarTienda.Name = "registrarTienda";
            this.registrarTienda.Size = new System.Drawing.Size(142, 23);
            this.registrarTienda.TabIndex = 12;
            this.registrarTienda.Text = "Registrar tienda";
            this.registrarTienda.UseVisualStyleBackColor = true;
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(50, 398);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 11;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            // 
            // direccion
            // 
            this.direccion.Enabled = false;
            this.direccion.Location = new System.Drawing.Point(28, 223);
            this.direccion.Multiline = true;
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(245, 84);
            this.direccion.TabIndex = 3;
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
            this.panel1.Location = new System.Drawing.Point(-6, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 65);
            this.panel1.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 29);
            this.label12.TabIndex = 0;
            this.label12.Text = "Listado Tiendas";
            // 
            // VentanaVerListadoTiendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(948, 626);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.panel1);
            this.Name = "VentanaVerListadoTiendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaVerListadoTiendas";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tiendas)).EndInit();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView tiendas;
        private System.Windows.Forms.ComboBox comboTiendas;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.ComboBox comboResponsable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registrarTienda;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox denominacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
    }
}