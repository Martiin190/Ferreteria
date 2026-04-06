using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreteria.bbdd;
using MySqlConnector;

namespace Ferreteria.Opciones_Admin
{
    public partial class VentanaVerListadoTiendas : Form
    {
        public VentanaVerListadoTiendas()
        {
            InitializeComponent();
            this.Load += VentanaVerListadoTiendas_Load;
            this.tiendas.SelectionChanged += tiendas_SelectionChanged;
            ConfiguracionInterfaz();
        }

        private void VentanaVerListadoTiendas_Load(object sender, EventArgs e)
        {
            CargarListadoTiendas();
            CargarResponsablesEnCombo();
        }

        private void ConfiguracionInterfaz()
        {
            panelDatos.Visible = false;
            tiendas.ReadOnly = true;
            tiendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tiendas.MultiSelect = false;
            tiendas.AllowUserToAddRows = false;
            tiendas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarListadoTiendas()
        {
            DataTable dt = Conexion.VerListadoTiendas();

            if (dt != null)
                tiendas.DataSource = dt;

            comboTiendas.DataSource = new DataTable();
            comboTiendas.DataSource = dt;
            comboTiendas.DisplayMember = "Denominacion";
            comboTiendas.ValueMember = "Denominacion";
            comboTiendas.SelectedIndex = -1;
        }

        private void CargarResponsablesEnCombo()
        {
            DataTable dt = Conexion.GetResponsables();

            if (dt != null)
            {
                comboResponsable.DataSource = dt;
                comboResponsable.DisplayMember = "nombre_apellidos";
                comboResponsable.ValueMember = "nombre_apellidos";
                comboResponsable.SelectedIndex = -1;
            }
        }

        private void tiendas_SelectionChanged(object sender, EventArgs e)
        {
            if (tiendas.SelectedRows.Count > 0)
            {
                DataRow fila = ((DataRowView)tiendas.SelectedRows[0].DataBoundItem).Row;

                denominacion.Text = fila["denominacion"].ToString();
                direccion.Text = fila["direccion"].ToString();
                comboResponsable.Text = fila["responsable"].ToString();

                panelDatos.Visible = true;
            }
        }

        private void registrarTienda_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(denominacion.Text) ||
                string.IsNullOrWhiteSpace(direccion.Text) ||
                comboResponsable.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos de registro son obligatorios", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool ok = Conexion.RegistrarTienda(
                denominacion.Text.Trim(),
                direccion.Text.Trim(),
                comboResponsable.SelectedValue.ToString()
            );

            if (ok)
            {
                MessageBox.Show("Registro realizado correctamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarListadoTiendas();
                LimpiarFormulario();
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            denominacion.Clear();
            direccion.Clear();
            comboResponsable.SelectedIndex = -1;
            tiendas.ClearSelection();
            panelDatos.Visible = false;
        }
    }
}
