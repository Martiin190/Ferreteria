using Ferreteria.bbdd;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.Opciones_Admin
{
    public partial class VentanaVerDatosCuenta : Form
    {
        private string _usuarioLogado = "admin";

        public VentanaVerDatosCuenta()
        {
            InitializeComponent();
            this.Load += VentanaVerDatosCuenta_Load;
            this._usuarioLogado = "admin";
        }

        private void VentanaVerDatosCuenta_Load(object sender, EventArgs e)
        {
            comboTipo.Items.Clear();
            comboTipo.Items.AddRange(new string[] { "admin", "user" });
            comboEstado.Items.Clear();
            comboEstado.Items.AddRange(new string[] { "activo", "bloqueado" });

            CargarDatos();
        }

        private void CargarDatos()
        {
            string userABuscar = string.IsNullOrEmpty(_usuarioLogado) ? "admin" : _usuarioLogado;

            DataTable dt = Conexion.ObtenerDatosUsuario(userABuscar);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow fila = dt.Rows[0];
                campoNombre.Text = fila["nombre_apellidos"].ToString();
                campoUsuario.Text = fila["usuario"].ToString();
                comboTipo.Text = fila["tipo"].ToString();
                comboEstado.Text = fila["estado"].ToString();
            }
            else
            {
                MessageBox.Show("No se pudieron cargar los datos del usuario '" + userABuscar + "'. Comprueba que existe en la DB.");
            }
        }



        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_usuarioLogado))
            {
                MessageBox.Show("Error: No se ha detectado el usuario logueado.");
                return;
            }

            if (string.IsNullOrWhiteSpace(campoNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                return;
            }

            string passFinal = null;
            if (!string.IsNullOrWhiteSpace(campoNuevaContrasenya.Text))
            {
                if (campoNuevaContrasenya.Text != campoConfirmarContrasenya.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden.");
                    return;
                }
                passFinal = campoNuevaContrasenya.Text.Trim();
            }

            // Intentar actualizar
            if (Conexion.ActualizarPerfil(_usuarioLogado, campoNombre.Text.Trim(), passFinal))
            {
                MessageBox.Show("¡Datos actualizados con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
