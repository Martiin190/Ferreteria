using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            }

            private void VentanaVerDatosCuenta_Load(object sender, EventArgs e)
            {
                CargarDatosCuenta();
                panelCambiarContrasenya.Visible = false;
            }

            private void CargarDatosCuenta()
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection())
                    {
                        conn.Open();
                        string query = @"SELECT usuario, tipo, estado, fecha_alta, nombre_apellidos
                                     FROM usuarios WHERE usuario = @usuario";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@usuario", _usuarioLogado);
                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            campoUsuario.Text = reader["usuario"].ToString();
                            comboTipo.Text = reader["tipo"].ToString();
                            comboEstado.Text = reader["estado"].ToString();
                            fechaAlta.Value = Convert.ToDateTime(reader["fecha_alta"]);
                            campoNombre.Text = reader["nombre_apellidos"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos de la cuenta:\n" + ex.Message,
                        "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void checkBoxCambiarContrasena_CheckedChanged(object sender, EventArgs e)
            {
                panelCambiarContrasenya.Visible = cambiarContrasenya.Checked;
            }

            private void btnGuardar_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrWhiteSpace(campoNombreYApellidos.Text))
                {
                    MessageBox.Show("El campo Nombre y apellidos no puede estar vacío.",
                        "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    campoNombreYApellidos.Focus();
                    return;
                }

                if (cambiarContrasenya.Checked)
                {
                    if (string.IsNullOrWhiteSpace(campoContrasenyaActual.Text) ||
                        string.IsNullOrWhiteSpace(campoNuevaContrasenya.Text) ||
                        string.IsNullOrWhiteSpace(campoConfirmarContrasenya.Text))
                    {
                        MessageBox.Show("Para cambiar la contraseña debes rellenar los tres campos de contraseña.",
                            "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!ContrasenaActualCorrecta(campoContrasenyaActual.Text.Trim()))
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

                    ActualizarNombreYContrasena(
                        campoNombre.Text.Trim(),
                        campoNuevaContrasenya.Text.Trim());
                }
                else
                {
                    ActualizarSoloNombre(campoNombre.Text.Trim());
                }
            }

            private bool ContrasenaActualCorrecta(string contrasenaIntroducida)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection())
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(
                            "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario AND pass = @pass", conn);
                        cmd.Parameters.AddWithValue("@usuario", _usuarioLogado);
                        cmd.Parameters.AddWithValue("@pass", contrasenaIntroducida);
                        return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                    }
                }
                catch
                {
                    return false;
                }
            }

            private void ActualizarSoloNombre(string nuevoNombre)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection())
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(
                            "UPDATE usuarios SET nombre_apellidos = @nombre WHERE usuario = @usuario", conn);
                        cmd.Parameters.AddWithValue("@nombre", nuevoNombre);
                        cmd.Parameters.AddWithValue("@usuario", _usuarioLogado);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Datos actualizados correctamente.",
                        "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar los datos:\n" + ex.Message,
                        "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void ActualizarNombreYContrasena(string nuevoNombre, string nuevaContrasena)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection())
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(
                            "UPDATE usuarios SET nombre_apellidos = @nombre, pass = @pass WHERE usuario = @usuario", conn);
                        cmd.Parameters.AddWithValue("@nombre", nuevoNombre);
                        cmd.Parameters.AddWithValue("@pass", nuevaContrasena);
                        cmd.Parameters.AddWithValue("@usuario", _usuarioLogado);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Datos y contraseña actualizados correctamente.",
                        "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cambiarContrasenya.Checked = false;
                    campoContrasenyaActual.Text = string.Empty;
                    campoNuevaContrasenya.Text = string.Empty;
                    campoConfirmarContrasenya.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar los datos:\n" + ex.Message,
                        "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btnCancelar_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        }
}
