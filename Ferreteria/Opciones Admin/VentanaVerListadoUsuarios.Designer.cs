namespace Ferreteria.Opciones_Admin
{
    partial class VentanaVerListadoUsuarios
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
            this.usuarios = new System.Windows.Forms.DataGridView();
            this.comboUsuarios = new System.Windows.Forms.ComboBox();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.comboTienda = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fechaAlta = new System.Windows.Forms.TextBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.actualizar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.usuario = new System.Windows.Forms.TextBox();
            this.nombreYApellidos = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios)).BeginInit();
            this.panelDatos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.usuarios);
            this.panel3.Controls.Add(this.comboUsuarios);
            this.panel3.Location = new System.Drawing.Point(13, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(633, 486);
            this.panel3.TabIndex = 36;
            // 
            // usuarios
            // 
            this.usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarios.Location = new System.Drawing.Point(7, 75);
            this.usuarios.Name = "usuarios";
            this.usuarios.RowHeadersWidth = 51;
            this.usuarios.RowTemplate.Height = 24;
            this.usuarios.Size = new System.Drawing.Size(623, 390);
            this.usuarios.TabIndex = 21;
            this.usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usuarios_CellContentClick);
            // 
            // comboUsuarios
            // 
            this.comboUsuarios.FormattingEnabled = true;
            this.comboUsuarios.Location = new System.Drawing.Point(67, 23);
            this.comboUsuarios.Name = "comboUsuarios";
            this.comboUsuarios.Size = new System.Drawing.Size(266, 24);
            this.comboUsuarios.TabIndex = 20;
            // 
            // panelDatos
            // 
            this.panelDatos.Controls.Add(this.comboTienda);
            this.panelDatos.Controls.Add(this.label6);
            this.panelDatos.Controls.Add(this.label5);
            this.panelDatos.Controls.Add(this.fechaAlta);
            this.panelDatos.Controls.Add(this.comboEstado);
            this.panelDatos.Controls.Add(this.label2);
            this.panelDatos.Controls.Add(this.comboTipo);
            this.panelDatos.Controls.Add(this.label1);
            this.panelDatos.Controls.Add(this.label4);
            this.panelDatos.Controls.Add(this.label3);
            this.panelDatos.Controls.Add(this.actualizar);
            this.panelDatos.Controls.Add(this.limpiar);
            this.panelDatos.Controls.Add(this.usuario);
            this.panelDatos.Controls.Add(this.nombreYApellidos);
            this.panelDatos.Location = new System.Drawing.Point(652, 71);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(305, 486);
            this.panelDatos.TabIndex = 35;
            // 
            // comboTienda
            // 
            this.comboTienda.FormattingEnabled = true;
            this.comboTienda.Location = new System.Drawing.Point(31, 288);
            this.comboTienda.Name = "comboTienda";
            this.comboTienda.Size = new System.Drawing.Size(242, 24);
            this.comboTienda.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Tienda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(28, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fecha de alta";
            // 
            // fechaAlta
            // 
            this.fechaAlta.Enabled = false;
            this.fechaAlta.Location = new System.Drawing.Point(28, 233);
            this.fechaAlta.Name = "fechaAlta";
            this.fechaAlta.Size = new System.Drawing.Size(245, 22);
            this.fechaAlta.TabIndex = 21;
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(25, 400);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(242, 24);
            this.comboEstado.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Estado";
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(28, 346);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(242, 24);
            this.comboTipo.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(25, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(25, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre y apellidos";
            // 
            // actualizar
            // 
            this.actualizar.Location = new System.Drawing.Point(125, 442);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(142, 23);
            this.actualizar.TabIndex = 12;
            this.actualizar.Text = "Actualizar";
            this.actualizar.UseVisualStyleBackColor = true;
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(44, 442);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 11;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            // 
            // usuario
            // 
            this.usuario.Enabled = false;
            this.usuario.Location = new System.Drawing.Point(25, 104);
            this.usuario.Multiline = true;
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(245, 84);
            this.usuario.TabIndex = 3;
            this.usuario.TextChanged += new System.EventHandler(this.usuario_TextChanged);
            // 
            // nombreYApellidos
            // 
            this.nombreYApellidos.Enabled = false;
            this.nombreYApellidos.Location = new System.Drawing.Point(25, 39);
            this.nombreYApellidos.Name = "nombreYApellidos";
            this.nombreYApellidos.Size = new System.Drawing.Size(245, 22);
            this.nombreYApellidos.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 65);
            this.panel1.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(208, 29);
            this.label12.TabIndex = 0;
            this.label12.Text = "Listado Usuarios";
            // 
            // VentanaVerListadoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(969, 569);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.panel1);
            this.Name = "VentanaVerListadoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaVerListadoUsuarios";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usuarios)).EndInit();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView usuarios;
        private System.Windows.Forms.ComboBox comboUsuarios;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button actualizar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox nombreYApellidos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fechaAlta;
        private System.Windows.Forms.ComboBox comboTienda;
        private System.Windows.Forms.Label label6;
    }
}