namespace Ferreteria.Opciones_Admin
{
    partial class VentanaVerDatosCuenta
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
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.panelCambiarContrasenya = new System.Windows.Forms.GroupBox();
            this.cambiarContrasenya = new System.Windows.Forms.CheckBox();
            this.campoNombreYApellidos = new System.Windows.Forms.TextBox();
            this.campoNombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fechaAlta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.campoUsuario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.campoContrasenyaActual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.campoNuevaContrasenya = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.campoConfirmarContrasenya = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelCambiarContrasenya.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(523, 453);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(122, 23);
            this.botonGuardar.TabIndex = 22;
            this.botonGuardar.Text = "Guardar cambios";
            this.botonGuardar.UseVisualStyleBackColor = true;
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(431, 453);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 20;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            // 
            // panelCambiarContrasenya
            // 
            this.panelCambiarContrasenya.Controls.Add(this.campoConfirmarContrasenya);
            this.panelCambiarContrasenya.Controls.Add(this.label7);
            this.panelCambiarContrasenya.Controls.Add(this.campoNuevaContrasenya);
            this.panelCambiarContrasenya.Controls.Add(this.label6);
            this.panelCambiarContrasenya.Controls.Add(this.campoContrasenyaActual);
            this.panelCambiarContrasenya.Controls.Add(this.label5);
            this.panelCambiarContrasenya.Controls.Add(this.cambiarContrasenya);
            this.panelCambiarContrasenya.Controls.Add(this.campoNombreYApellidos);
            this.panelCambiarContrasenya.Controls.Add(this.campoNombre);
            this.panelCambiarContrasenya.Location = new System.Drawing.Point(42, 310);
            this.panelCambiarContrasenya.Name = "panelCambiarContrasenya";
            this.panelCambiarContrasenya.Size = new System.Drawing.Size(603, 137);
            this.panelCambiarContrasenya.TabIndex = 19;
            this.panelCambiarContrasenya.TabStop = false;
            this.panelCambiarContrasenya.Text = "DATOS EDITABLES";
            // 
            // cambiarContrasenya
            // 
            this.cambiarContrasenya.AutoSize = true;
            this.cambiarContrasenya.Location = new System.Drawing.Point(35, 111);
            this.cambiarContrasenya.Name = "cambiarContrasenya";
            this.cambiarContrasenya.Size = new System.Drawing.Size(208, 20);
            this.cambiarContrasenya.TabIndex = 12;
            this.cambiarContrasenya.Text = "Quiero cambiar mi contraseña";
            this.cambiarContrasenya.UseVisualStyleBackColor = true;
            // 
            // campoNombreYApellidos
            // 
            this.campoNombreYApellidos.Location = new System.Drawing.Point(35, 53);
            this.campoNombreYApellidos.Name = "campoNombreYApellidos";
            this.campoNombreYApellidos.Size = new System.Drawing.Size(122, 22);
            this.campoNombreYApellidos.TabIndex = 11;
            // 
            // campoNombre
            // 
            this.campoNombre.AutoSize = true;
            this.campoNombre.Location = new System.Drawing.Point(32, 34);
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.Size = new System.Drawing.Size(56, 16);
            this.campoNombre.TabIndex = 0;
            this.campoNombre.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboTipo);
            this.groupBox1.Controls.Add(this.comboEstado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fechaAlta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.campoUsuario);
            this.groupBox1.Location = new System.Drawing.Point(42, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 181);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DE SOLO LECTURA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de alta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estado";
            // 
            // fechaAlta
            // 
            this.fechaAlta.Location = new System.Drawing.Point(335, 132);
            this.fechaAlta.Name = "fechaAlta";
            this.fechaAlta.Size = new System.Drawing.Size(250, 22);
            this.fechaAlta.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // campoUsuario
            // 
            this.campoUsuario.Location = new System.Drawing.Point(32, 52);
            this.campoUsuario.Name = "campoUsuario";
            this.campoUsuario.Size = new System.Drawing.Size(236, 22);
            this.campoUsuario.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(6, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 65);
            this.panel1.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(234, 29);
            this.label12.TabIndex = 0;
            this.label12.Text = "Datos de la Cuenta";
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(32, 132);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(188, 24);
            this.comboEstado.TabIndex = 9;
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(335, 50);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(188, 24);
            this.comboTipo.TabIndex = 10;
            // 
            // campoContrasenyaActual
            // 
            this.campoContrasenyaActual.Location = new System.Drawing.Point(208, 53);
            this.campoContrasenyaActual.Name = "campoContrasenyaActual";
            this.campoContrasenyaActual.Size = new System.Drawing.Size(122, 22);
            this.campoContrasenyaActual.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Contraseña actual";
            // 
            // campoNuevaContrasenya
            // 
            this.campoNuevaContrasenya.Location = new System.Drawing.Point(373, 53);
            this.campoNuevaContrasenya.Name = "campoNuevaContrasenya";
            this.campoNuevaContrasenya.Size = new System.Drawing.Size(122, 22);
            this.campoNuevaContrasenya.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nueva contraseña";
            // 
            // campoConfirmarContrasenya
            // 
            this.campoConfirmarContrasenya.Location = new System.Drawing.Point(373, 100);
            this.campoConfirmarContrasenya.Name = "campoConfirmarContrasenya";
            this.campoConfirmarContrasenya.Size = new System.Drawing.Size(122, 22);
            this.campoConfirmarContrasenya.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Confirmar contraseña";
            // 
            // VentanaVerDatosCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(694, 475);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.panelCambiarContrasenya);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "VentanaVerDatosCuenta";
            this.Text = "VentanaVerDatosCuenta";
            this.panelCambiarContrasenya.ResumeLayout(false);
            this.panelCambiarContrasenya.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.GroupBox panelCambiarContrasenya;
        private System.Windows.Forms.Label campoNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fechaAlta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox campoUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cambiarContrasenya;
        private System.Windows.Forms.TextBox campoNombreYApellidos;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.TextBox campoConfirmarContrasenya;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox campoNuevaContrasenya;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox campoContrasenyaActual;
        private System.Windows.Forms.Label label5;
    }
}