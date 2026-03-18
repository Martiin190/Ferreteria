namespace Ferreteria.Vistas
{
    partial class VentanaUser
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
            this.grupoUsuario = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.campoNombre = new System.Windows.Forms.TextBox();
            this.campoApellidos = new System.Windows.Forms.TextBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.grupoUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupoUsuario
            // 
            this.grupoUsuario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grupoUsuario.Controls.Add(this.comboEstado);
            this.grupoUsuario.Controls.Add(this.comboTipo);
            this.grupoUsuario.Controls.Add(this.campoApellidos);
            this.grupoUsuario.Controls.Add(this.campoNombre);
            this.grupoUsuario.Controls.Add(this.label6);
            this.grupoUsuario.Controls.Add(this.label5);
            this.grupoUsuario.Controls.Add(this.label4);
            this.grupoUsuario.Controls.Add(this.label3);
            this.grupoUsuario.Controls.Add(this.label2);
            this.grupoUsuario.Controls.Add(this.label1);
            this.grupoUsuario.Location = new System.Drawing.Point(143, 124);
            this.grupoUsuario.Name = "grupoUsuario";
            this.grupoUsuario.Size = new System.Drawing.Size(685, 441);
            this.grupoUsuario.TabIndex = 0;
            this.grupoUsuario.TabStop = false;
            this.grupoUsuario.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de alta";
            // 
            // campoNombre
            // 
            this.campoNombre.Location = new System.Drawing.Point(194, 60);
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.Size = new System.Drawing.Size(181, 22);
            this.campoNombre.TabIndex = 6;
            // 
            // campoApellidos
            // 
            this.campoApellidos.Location = new System.Drawing.Point(194, 109);
            this.campoApellidos.Name = "campoApellidos";
            this.campoApellidos.Size = new System.Drawing.Size(181, 22);
            this.campoApellidos.TabIndex = 7;
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(194, 221);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(156, 24);
            this.comboTipo.TabIndex = 8;
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(194, 274);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(156, 24);
            this.comboEstado.TabIndex = 9;
            // 
            // VentanaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1005, 657);
            this.Controls.Add(this.grupoUsuario);
            this.Name = "VentanaUser";
            this.Text = "VentanaUser";
            this.grupoUsuario.ResumeLayout(false);
            this.grupoUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupoUsuario;
        private System.Windows.Forms.TextBox campoApellidos;
        private System.Windows.Forms.TextBox campoNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.ComboBox comboTipo;
    }
}