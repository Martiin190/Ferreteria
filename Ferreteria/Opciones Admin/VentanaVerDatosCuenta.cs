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
        private readonly string _usuarioLogado;

        public VentanaVerDatosCuenta()
        {
            InitializeComponent();
        }

        public VentanaVerDatosCuenta(string usuarioLogado)
        {
            InitializeComponent();
            _usuarioLogado = usuarioLogado;
            this.Load += VentanaVerDatosCuenta_Load;
        }

        private void VentanaVerDatosCuenta_Load(object sender, EventArgs e)
        {
            CargarDatosCuenta();
            panelCambiarContrasenya.Visible = false;
        }

        private void CargarDatosCuenta()
        {
            MySqlConnector.MySqlDataReader reader = Conexion.GetDatosCuenta(_usuarioLogado);

            try
            {
                if (reader.Read())
                {
                    campoUsuario.Text = reader["usuario"].ToString();
                    campoNombre.Text = reader["nombre_apellidos"].ToString();
                    comboTipo.Text = reader["tipo"].ToString();
                    comboEstado.Text = reader["estado"].ToString();
                    fechaAlta.Value = Convert.ToDateTime(reader["fecha_alta"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de la cuenta:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                reader?.Close();
            }
        }

        private void checkBoxCambiarContrasena_CheckedChanged(object sender, EventArgs e)
        {
            panelCambiarContrasenya.Visible = cambiarContrasenya.Checked;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(campoNombre.Text))
            {
                MessageBox.Show("El campo Nombre y apellidos no puede estar vacío.",
                    "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                campoNombre.Focus();
                return;
            }

            if (cambiarContrasenya.Checked)
            {
                if (string.IsNullOrWhiteSpace(campoContrasenyaActual.Text) ||
                    string.IsNullOrWhiteSpace(campoNuevaContrasenya.Text) ||
                    string.IsNullOrWhiteSpace(campoConfirmarContrasenya.Text))
                {
                    MessageBox.Show("Para cambiar la contraseña debes rellenar los tres campos.",
                        "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!Conexion.VerificarPass(_usuarioLogado, campoContrasenyaActual.Text.Trim()))
                {
                    MessageBox.Show("La contraseña actual introducida no es correcta.",
                        "Contraseña incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    campoContrasenyaActual.Focus();
                    campoContrasenyaActual.SelectAll();
                    return;
                }

                if (campoNuevaContrasenya.Text.Trim() != campoConfirmarContrasenya.Text.Trim())
                {
                    MessageBox.Show("La nueva contraseña y la confirmación no coinciden.",
                        "Contraseñas no coinciden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    campoNuevaContrasenya.Focus();
                    campoNuevaContrasenya.SelectAll();
                    return;
                }

                bool ok = Conexion.ActualizarCuenta(
                    _usuarioLogado,
                    campoNombre.Text.Trim(),
                    campoNuevaContrasenya.Text.Trim()
                );

                if (ok)
                {
                    MessageBox.Show("Datos y contraseña actualizados correctamente.",
                        "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cambiarContrasenya.Checked = false;
                    campoContrasenyaActual.Clear();
                    campoNuevaContrasenya.Clear();
                    campoConfirmarContrasenya.Clear();
                }
            }
            else
            {
                bool ok = Conexion.ActualizarCuenta(
                    _usuarioLogado,
                    campoNombre.Text.Trim(),
                    null
                );

                if (ok)
                    MessageBox.Show("Datos actualizados correctamente.",
                        "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
