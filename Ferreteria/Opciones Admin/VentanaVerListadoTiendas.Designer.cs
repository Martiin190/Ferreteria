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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CampoDenominacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BotonCerrar = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.CampoDireccion = new System.Windows.Forms.TextBox();
            this.ComboResponsable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(120, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(695, 186);
            this.dataGridView1.TabIndex = 46;
            // 
            // CampoDenominacion
            // 
            this.CampoDenominacion.Location = new System.Drawing.Point(210, 352);
            this.CampoDenominacion.Name = "CampoDenominacion";
            this.CampoDenominacion.Size = new System.Drawing.Size(100, 22);
            this.CampoDenominacion.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(107, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(107, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Denominacion:";
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.Location = new System.Drawing.Point(385, 471);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(126, 23);
            this.BotonCerrar.TabIndex = 42;
            this.BotonCerrar.Text = "Cerrar";
            this.BotonCerrar.UseVisualStyleBackColor = true;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // actualizar
            // 
            this.actualizar.Location = new System.Drawing.Point(174, 471);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(179, 23);
            this.actualizar.TabIndex = 43;
            this.actualizar.Text = "Actualizar";
            this.actualizar.UseVisualStyleBackColor = true;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // CampoDireccion
            // 
            this.CampoDireccion.Location = new System.Drawing.Point(210, 388);
            this.CampoDireccion.Multiline = true;
            this.CampoDireccion.Name = "CampoDireccion";
            this.CampoDireccion.Size = new System.Drawing.Size(204, 23);
            this.CampoDireccion.TabIndex = 41;
            // 
            // ComboResponsable
            // 
            this.ComboResponsable.FormattingEnabled = true;
            this.ComboResponsable.Location = new System.Drawing.Point(210, 427);
            this.ComboResponsable.Name = "ComboResponsable";
            this.ComboResponsable.Size = new System.Drawing.Size(204, 24);
            this.ComboResponsable.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(107, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Responsable";
            // 
            // VentanaVerListadoTiendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(948, 626);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboResponsable);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CampoDenominacion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CampoDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.BotonCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VentanaVerListadoTiendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaVerListadoTiendas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox CampoDenominacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BotonCerrar;
        private System.Windows.Forms.Button actualizar;
        private System.Windows.Forms.TextBox CampoDireccion;
        private System.Windows.Forms.ComboBox ComboResponsable;
        private System.Windows.Forms.Label label1;
    }
}