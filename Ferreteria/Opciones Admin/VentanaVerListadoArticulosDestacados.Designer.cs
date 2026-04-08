namespace Ferreteria.Opciones_Admin
{
    partial class VentanaVerListadoArticulosDestacados
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
            this.a = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.CampoCodigo = new System.Windows.Forms.TextBox();
            this.CampoCategoria = new System.Windows.Forms.TextBox();
            this.CampoNombre = new System.Windows.Forms.TextBox();
            this.CampoDescripcion = new System.Windows.Forms.TextBox();
            this.CampoPrecioCompra = new System.Windows.Forms.TextBox();
            this.CampoPrecioVenta = new System.Windows.Forms.TextBox();
            this.CampoStock = new System.Windows.Forms.TextBox();
            this.CampoOrigen = new System.Windows.Forms.TextBox();
            this.CampoOferta = new System.Windows.Forms.TextBox();
            this.CampoFecha = new System.Windows.Forms.TextBox();
            this.eliminar = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ComboDestacado = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(490, 701);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(77, 16);
            this.a.TabIndex = 25;
            this.a.Text = "Destacado:";
            this.a.Click += new System.EventHandler(this.a_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(1, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 65);
            this.panel1.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(387, 29);
            this.label12.TabIndex = 0;
            this.label12.Text = "Listado de Articulos Destacados";
            // 
            // CampoCodigo
            // 
            this.CampoCodigo.Enabled = false;
            this.CampoCodigo.Location = new System.Drawing.Point(155, 16);
            this.CampoCodigo.Name = "CampoCodigo";
            this.CampoCodigo.Size = new System.Drawing.Size(100, 22);
            this.CampoCodigo.TabIndex = 0;
            // 
            // CampoCategoria
            // 
            this.CampoCategoria.Enabled = false;
            this.CampoCategoria.Location = new System.Drawing.Point(155, 45);
            this.CampoCategoria.Name = "CampoCategoria";
            this.CampoCategoria.Size = new System.Drawing.Size(100, 22);
            this.CampoCategoria.TabIndex = 1;
            // 
            // CampoNombre
            // 
            this.CampoNombre.Enabled = false;
            this.CampoNombre.Location = new System.Drawing.Point(155, 75);
            this.CampoNombre.Name = "CampoNombre";
            this.CampoNombre.Size = new System.Drawing.Size(245, 22);
            this.CampoNombre.TabIndex = 2;
            // 
            // CampoDescripcion
            // 
            this.CampoDescripcion.Enabled = false;
            this.CampoDescripcion.Location = new System.Drawing.Point(155, 103);
            this.CampoDescripcion.Multiline = true;
            this.CampoDescripcion.Name = "CampoDescripcion";
            this.CampoDescripcion.Size = new System.Drawing.Size(245, 23);
            this.CampoDescripcion.TabIndex = 3;
            // 
            // CampoPrecioCompra
            // 
            this.CampoPrecioCompra.Enabled = false;
            this.CampoPrecioCompra.Location = new System.Drawing.Point(155, 132);
            this.CampoPrecioCompra.Name = "CampoPrecioCompra";
            this.CampoPrecioCompra.Size = new System.Drawing.Size(100, 22);
            this.CampoPrecioCompra.TabIndex = 4;
            // 
            // CampoPrecioVenta
            // 
            this.CampoPrecioVenta.Enabled = false;
            this.CampoPrecioVenta.Location = new System.Drawing.Point(155, 160);
            this.CampoPrecioVenta.Name = "CampoPrecioVenta";
            this.CampoPrecioVenta.Size = new System.Drawing.Size(100, 22);
            this.CampoPrecioVenta.TabIndex = 5;
            // 
            // CampoStock
            // 
            this.CampoStock.Enabled = false;
            this.CampoStock.Location = new System.Drawing.Point(155, 188);
            this.CampoStock.Name = "CampoStock";
            this.CampoStock.Size = new System.Drawing.Size(100, 22);
            this.CampoStock.TabIndex = 6;
            // 
            // CampoOrigen
            // 
            this.CampoOrigen.Enabled = false;
            this.CampoOrigen.Location = new System.Drawing.Point(155, 216);
            this.CampoOrigen.Name = "CampoOrigen";
            this.CampoOrigen.Size = new System.Drawing.Size(100, 22);
            this.CampoOrigen.TabIndex = 7;
            // 
            // CampoOferta
            // 
            this.CampoOferta.Enabled = false;
            this.CampoOferta.Location = new System.Drawing.Point(155, 244);
            this.CampoOferta.Name = "CampoOferta";
            this.CampoOferta.Size = new System.Drawing.Size(242, 22);
            this.CampoOferta.TabIndex = 9;
            // 
            // CampoFecha
            // 
            this.CampoFecha.Enabled = false;
            this.CampoFecha.Location = new System.Drawing.Point(155, 275);
            this.CampoFecha.Name = "CampoFecha";
            this.CampoFecha.Size = new System.Drawing.Size(245, 22);
            this.CampoFecha.TabIndex = 10;
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(37, 350);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(126, 23);
            this.eliminar.TabIndex = 11;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            // 
            // actualizar
            // 
            this.actualizar.Location = new System.Drawing.Point(190, 350);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(179, 23);
            this.actualizar.TabIndex = 12;
            this.actualizar.Text = "Actualizar";
            this.actualizar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(23, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(23, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(23, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Precio compra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(23, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Precio venta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(23, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Stock";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(23, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Origen";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(23, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Oferta";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Location = new System.Drawing.Point(23, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Fecha de alta";
            // 
            // panelDatos
            // 
            this.panelDatos.Controls.Add(this.label11);
            this.panelDatos.Controls.Add(this.label10);
            this.panelDatos.Controls.Add(this.label8);
            this.panelDatos.Controls.Add(this.label7);
            this.panelDatos.Controls.Add(this.label6);
            this.panelDatos.Controls.Add(this.label5);
            this.panelDatos.Controls.Add(this.label4);
            this.panelDatos.Controls.Add(this.label3);
            this.panelDatos.Controls.Add(this.label2);
            this.panelDatos.Controls.Add(this.label1);
            this.panelDatos.Controls.Add(this.actualizar);
            this.panelDatos.Controls.Add(this.eliminar);
            this.panelDatos.Controls.Add(this.CampoFecha);
            this.panelDatos.Controls.Add(this.CampoOferta);
            this.panelDatos.Controls.Add(this.CampoOrigen);
            this.panelDatos.Controls.Add(this.CampoStock);
            this.panelDatos.Controls.Add(this.CampoPrecioVenta);
            this.panelDatos.Controls.Add(this.CampoPrecioCompra);
            this.panelDatos.Controls.Add(this.CampoDescripcion);
            this.panelDatos.Controls.Add(this.CampoNombre);
            this.panelDatos.Controls.Add(this.CampoCategoria);
            this.panelDatos.Controls.Add(this.CampoCodigo);
            this.panelDatos.Location = new System.Drawing.Point(20, 496);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(431, 376);
            this.panelDatos.TabIndex = 29;
            this.panelDatos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDatos_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(833, 406);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ComboDestacado
            // 
            this.ComboDestacado.FormattingEnabled = true;
            this.ComboDestacado.Location = new System.Drawing.Point(572, 709);
            this.ComboDestacado.Name = "ComboDestacado";
            this.ComboDestacado.Size = new System.Drawing.Size(138, 24);
            this.ComboDestacado.TabIndex = 30;
            this.ComboDestacado.SelectedIndexChanged += new System.EventHandler(this.ComboDestacado_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 736);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Cambiar Destacado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // VentanaVerListadoArticulosDestacados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(866, 885);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ComboDestacado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.a);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VentanaVerListadoArticulosDestacados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaVerListadoArticulosDestacados";
            this.Load += new System.EventHandler(this.VentanaVerListadoArticulosDestacados_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox CampoCodigo;
        private System.Windows.Forms.TextBox CampoCategoria;
        private System.Windows.Forms.TextBox CampoNombre;
        private System.Windows.Forms.TextBox CampoDescripcion;
        private System.Windows.Forms.TextBox CampoPrecioCompra;
        private System.Windows.Forms.TextBox CampoPrecioVenta;
        private System.Windows.Forms.TextBox CampoStock;
        private System.Windows.Forms.TextBox CampoOrigen;
        private System.Windows.Forms.TextBox CampoOferta;
        private System.Windows.Forms.TextBox CampoFecha;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button actualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ComboDestacado;
        private System.Windows.Forms.Button button1;
    }
}