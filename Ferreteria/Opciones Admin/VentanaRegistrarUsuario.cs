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
    public partial class VentanaRegistrarUsuario : Form
    {
        public VentanaRegistrarUsuario()
        {
            InitializeComponent();
            Load += VentanaRegistrarUsuario_Load;
        }

        private void VentanaRegistrarUsuario_Load(object sender, EventArgs e)
        {
            CargarCombos();
            fechaAlta.Value = DateTime.Now;
        }

        private void CargarCombos()
        {
            DataTable dtTiendas = Conexion.VerListadoTiendas();
            if (dtTiendas != null)
            {
                comboTienda.DataSource = dtTiendas;
                comboTienda.DisplayMember = "denominacion";
                comboTienda.ValueMember = "denominacion";
                comboTienda.SelectedIndex = -1;
            }

            comboTipo.Items.Clear();
            comboTipo.Items.AddRange(new string[] { "admin", "user" });

            comboEstado.Items.Clear();
            comboEstado.Items.Add("activo");
            comboEstado.Items.Add("bloqueado");
        }


        private void LimpiarCampos()
        {
            campoNombreYApellidos.Clear();
            campoUsuario.Clear();
            campoContrasenya.Clear();
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

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(campoNombreYApellidos.Text) ||
                string.IsNullOrWhiteSpace(campoUsuario.Text) ||
                string.IsNullOrWhiteSpace(campoContrasenya.Text) ||
                comboTipo.SelectedIndex == -1 ||
                comboEstado.SelectedIndex == -1 ||
                comboTienda.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Aviso");
                return;
            }

            bool exito = Conexion.RegistrarUsuario(
                campoNombreYApellidos.Text.Trim(),
                comboTienda.Text,
                campoUsuario.Text.Trim(),
                campoContrasenya.Text.Trim(),
                comboTipo.Text,
                comboEstado.Text,
                fechaAlta.Value.Date
            );

            if (exito)
            {
                MessageBox.Show("Usuario registrado con éxito.", "Hecho");
                LimpiarCampos();
            }
        }
    }
}
