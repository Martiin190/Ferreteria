using System;
using Ferreteria.Modelos;
using Ferreteria.Utilidades;

namespace Ferreteria.Opciones_Admin
{
    //prueba1
    partial class VentanaRegistrarArticulo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.campoDescripcion = new System.Windows.Forms.TextBox();
            this.campoNombre = new System.Windows.Forms.TextBox();
            this.campoCodigo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fechaAlta = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboOrigen = new System.Windows.Forms.ComboBox();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.campoStock = new System.Windows.Forms.TextBox();
            this.campoPrecioVenta = new System.Windows.Forms.TextBox();
            this.campoPrecioCompra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grupoOfertas = new System.Windows.Forms.GroupBox();
            this.radioOfertaNo = new System.Windows.Forms.RadioButton();
            this.radioOfertaSi = new System.Windows.Forms.RadioButton();
            this.grupoDestacados = new System.Windows.Forms.GroupBox();
            this.radioDestacadoSi = new System.Windows.Forms.RadioButton();
            this.radioDestacadoNo = new System.Windows.Forms.RadioButton();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grupoOfertas.SuspendLayout();
            this.grupoDestacados.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 65);
            this.panel1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(215, 29);
            this.label12.TabIndex = 0;
            this.label12.Text = "Registrar Articulo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.campoDescripcion);
            this.groupBox1.Controls.Add(this.campoNombre);
            this.groupBox1.Controls.Add(this.campoCodigo);
            this.groupBox1.Location = new System.Drawing.Point(37, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 248);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IDENTIFICACION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo de producto";
            // 
            // campoDescripcion
            // 
            this.campoDescripcion.Location = new System.Drawing.Point(32, 118);
            this.campoDescripcion.Multiline = true;
            this.campoDescripcion.Name = "campoDescripcion";
            this.campoDescripcion.Size = new System.Drawing.Size(536, 107);
            this.campoDescripcion.TabIndex = 2;
            // 
            // campoNombre
            // 
            this.campoNombre.Location = new System.Drawing.Point(332, 52);
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.Size = new System.Drawing.Size(236, 22);
            this.campoNombre.TabIndex = 1;
            // 
            // campoCodigo
            // 
            this.campoCodigo.Location = new System.Drawing.Point(32, 52);
            this.campoCodigo.Name = "campoCodigo";
            this.campoCodigo.Size = new System.Drawing.Size(236, 22);
            this.campoCodigo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fechaAlta);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboOrigen);
            this.groupBox2.Controls.Add(this.comboCategoria);
            this.groupBox2.Location = new System.Drawing.Point(37, 386);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CLASIFICACION";
            // 
            // fechaAlta
            // 
            this.fechaAlta.Location = new System.Drawing.Point(356, 55);
            this.fechaAlta.Name = "fechaAlta";
            this.fechaAlta.Size = new System.Drawing.Size(241, 22);
            this.fechaAlta.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de alta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Origen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria";
            // 
            // comboOrigen
            // 
            this.comboOrigen.FormattingEnabled = true;
            this.comboOrigen.Location = new System.Drawing.Point(214, 53);
            this.comboOrigen.Name = "comboOrigen";
            this.comboOrigen.Size = new System.Drawing.Size(120, 24);
            this.comboOrigen.TabIndex = 1;
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(32, 53);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(126, 24);
            this.comboCategoria.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.campoStock);
            this.groupBox3.Controls.Add(this.campoPrecioVenta);
            this.groupBox3.Controls.Add(this.campoPrecioCompra);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(37, 516);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(603, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PRECIO Y STOCK";
            // 
            // campoStock
            // 
            this.campoStock.Location = new System.Drawing.Point(386, 53);
            this.campoStock.Name = "campoStock";
            this.campoStock.Size = new System.Drawing.Size(143, 22);
            this.campoStock.TabIndex = 5;
            // 
            // campoPrecioVenta
            // 
            this.campoPrecioVenta.Location = new System.Drawing.Point(214, 53);
            this.campoPrecioVenta.Name = "campoPrecioVenta";
            this.campoPrecioVenta.Size = new System.Drawing.Size(143, 22);
            this.campoPrecioVenta.TabIndex = 4;
            // 
            // campoPrecioCompra
            // 
            this.campoPrecioCompra.Location = new System.Drawing.Point(35, 53);
            this.campoPrecioCompra.Name = "campoPrecioCompra";
            this.campoPrecioCompra.Size = new System.Drawing.Size(143, 22);
            this.campoPrecioCompra.TabIndex = 3;
            this.campoPrecioCompra.TextChanged += new System.EventHandler(this.campoPrecioCompra_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(383, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Stock";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Precio de venta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Precio de compra";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grupoOfertas);
            this.groupBox4.Controls.Add(this.grupoDestacados);
            this.groupBox4.Location = new System.Drawing.Point(37, 634);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(603, 93);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ESTADO";
            // 
            // grupoOfertas
            // 
            this.grupoOfertas.Controls.Add(this.radioOfertaNo);
            this.grupoOfertas.Controls.Add(this.radioOfertaSi);
            this.grupoOfertas.Location = new System.Drawing.Point(397, 21);
            this.grupoOfertas.Name = "grupoOfertas";
            this.grupoOfertas.Size = new System.Drawing.Size(132, 72);
            this.grupoOfertas.TabIndex = 7;
            this.grupoOfertas.TabStop = false;
            this.grupoOfertas.Text = "Ofertas";
            // 
            // radioOfertaNo
            // 
            this.radioOfertaNo.AutoSize = true;
            this.radioOfertaNo.Location = new System.Drawing.Point(67, 45);
            this.radioOfertaNo.Name = "radioOfertaNo";
            this.radioOfertaNo.Size = new System.Drawing.Size(46, 20);
            this.radioOfertaNo.TabIndex = 5;
            this.radioOfertaNo.TabStop = true;
            this.radioOfertaNo.Text = "No";
            this.radioOfertaNo.UseVisualStyleBackColor = true;
            // 
            // radioOfertaSi
            // 
            this.radioOfertaSi.AutoSize = true;
            this.radioOfertaSi.Location = new System.Drawing.Point(10, 45);
            this.radioOfertaSi.Name = "radioOfertaSi";
            this.radioOfertaSi.Size = new System.Drawing.Size(40, 20);
            this.radioOfertaSi.TabIndex = 4;
            this.radioOfertaSi.TabStop = true;
            this.radioOfertaSi.Text = "Si";
            this.radioOfertaSi.UseVisualStyleBackColor = true;
            // 
            // grupoDestacados
            // 
            this.grupoDestacados.Controls.Add(this.radioDestacadoSi);
            this.grupoDestacados.Controls.Add(this.radioDestacadoNo);
            this.grupoDestacados.Location = new System.Drawing.Point(78, 21);
            this.grupoDestacados.Name = "grupoDestacados";
            this.grupoDestacados.Size = new System.Drawing.Size(132, 71);
            this.grupoDestacados.TabIndex = 6;
            this.grupoDestacados.TabStop = false;
            this.grupoDestacados.Text = "Destacados";
            // 
            // radioDestacadoSi
            // 
            this.radioDestacadoSi.AutoSize = true;
            this.radioDestacadoSi.Location = new System.Drawing.Point(10, 42);
            this.radioDestacadoSi.Name = "radioDestacadoSi";
            this.radioDestacadoSi.Size = new System.Drawing.Size(40, 20);
            this.radioDestacadoSi.TabIndex = 2;
            this.radioDestacadoSi.TabStop = true;
            this.radioDestacadoSi.Text = "Si";
            this.radioDestacadoSi.UseVisualStyleBackColor = true;
            // 
            // radioDestacadoNo
            // 
            this.radioDestacadoNo.AutoSize = true;
            this.radioDestacadoNo.Location = new System.Drawing.Point(70, 42);
            this.radioDestacadoNo.Name = "radioDestacadoNo";
            this.radioDestacadoNo.Size = new System.Drawing.Size(46, 20);
            this.radioDestacadoNo.TabIndex = 3;
            this.radioDestacadoNo.TabStop = true;
            this.radioDestacadoNo.Text = "No";
            this.radioDestacadoNo.UseVisualStyleBackColor = true;
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(274, 733);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 5;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(156, 733);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 6;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.Location = new System.Drawing.Point(372, 733);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(122, 23);
            this.botonRegistrar.TabIndex = 7;
            this.botonRegistrar.Text = "Registrar articulo";
            this.botonRegistrar.UseVisualStyleBackColor = true;
            this.botonRegistrar.Click += new System.EventHandler(this.botonRegistrar_Click);
            // 
            // VentanaRegistrarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(691, 764);
            this.Controls.Add(this.botonRegistrar);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "VentanaRegistrarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaRegistrarArticulo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.grupoOfertas.ResumeLayout(false);
            this.grupoOfertas.PerformLayout();
            this.grupoDestacados.ResumeLayout(false);
            this.grupoDestacados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox campoDescripcion;
        private System.Windows.Forms.TextBox campoNombre;
        private System.Windows.Forms.TextBox campoCodigo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboOrigen;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fechaAlta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox campoStock;
        private System.Windows.Forms.TextBox campoPrecioVenta;
        private System.Windows.Forms.TextBox campoPrecioCompra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioOfertaNo;
        private System.Windows.Forms.RadioButton radioOfertaSi;
        private System.Windows.Forms.RadioButton radioDestacadoNo;
        private System.Windows.Forms.RadioButton radioDestacadoSi;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonRegistrar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grupoOfertas;
        private System.Windows.Forms.GroupBox grupoDestacados;
    }
}