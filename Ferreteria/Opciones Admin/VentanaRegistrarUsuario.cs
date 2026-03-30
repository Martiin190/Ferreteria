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
    public partial class VentanaRegistrarUsuario : Form
    {
        public VentanaRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void VentanaRegistrarUsuario_Load(object sender, EventArgs e)
        {
            fechaAlta.Value = DateTime.Now;
            CargarTiendas();
        }

        private void CargarTiendas()
        {
            comboTienda.Items.Clear();

            try
            {
                using (MySqlConnection conn = new MySqlConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(
                        "SELECT denominacion FROM tiendas ORDER BY denominacion ASC", conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                        comboTienda.Items.Add(reader["denominacion"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las tiendas:\n" + ex.Message,
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(campoNombreYApellidos.Text) ||
                string.IsNullOrWhiteSpace(campoUsuario.Text) ||
                string.IsNullOrWhiteSpace(campoContrasenya.Text) ||
                comboTipo.SelectedIndex == -1 ||
                comboEstado.SelectedIndex == -1 ||
                comboTienda.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos son obligatorios.",
                    "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UsuarioExiste(campoUsuario.Text.Trim()))
            {
                MessageBox.Show(
                    $"El usuario \"{campoUsuario.Text.Trim()}\" ya existe.\nElige un nombre diferente.",
                    "Usuario duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                campoUsuario.Focus();
                campoUsuario.SelectAll();
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO usuarios
                        (nombre_apellidos, tienda, usuario, pass, tipo, estado, fecha_alta)
                        VALUES (@nombre, @tienda, @usuario, @pass, @tipo, @estado, @fechaAlta)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", campoNombreYApellidos.Text.Trim());
                    cmd.Parameters.AddWithValue("@tienda", comboTienda.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@usuario", campoUsuario.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", campoContrasenya.Text.Trim());
                    cmd.Parameters.AddWithValue("@tipo", comboTipo.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@estado", comboEstado.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@fechaAlta", fechaAlta.Value.Date);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Usuario registrado correctamente.",
                    "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario:\n" + ex.Message,
                    "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UsuarioExiste(string nombreUsuario)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(
                        "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario", conn);
                    cmd.Parameters.AddWithValue("@usuario", nombreUsuario);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        private void LimpiarCampos()
        {
            campoNombreYApellidos.Clear();
            campoUsuario.Clear();
            campoContrasenya.Clear();;
            comboTipo.SelectedIndex = -1;
            comboEstado.SelectedIndex = -1;
            comboTienda.SelectedIndex = -1;
            fechaAlta.Value = DateTime.Now;
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
