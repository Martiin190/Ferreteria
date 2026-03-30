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

namespace Ferreteria.Opciones_Admin
{
    public partial class VentanaVerListadoTiendas : Form
    {
        public VentanaVerListadoTiendas()
        {
            InitializeComponent();
        }

        private void VentanaVerListadoTiendas_Load(object sender, EventArgs e)
        {
            CargarListadoTiendas();
            CargarResponsablesEnCombo(); 
        }

        private void ConfiguracionInterfaz()
        {
            panelDatos.Visible = false;
        }

        private void CargarListadoTiendas()
        {
            // Consulta: "SELECT denominacion, direccion, responsable FROM tiendas"
            // dgvTiendas.DataSource = db.Consultar(sql);
        }

        private void CargarResponsablesEnCombo()
        {
            //comboResponsable.DataSource = Conexion.Consultar("SELECT nombre_apellidos FROM responsables_tienda");
        }

        private void tiendas_SelectionChanged(object sender, EventArgs e)
        {
            if (tiendas.SelectedRows.Count > 0)
            {
                panelDatos.Visible = true;

                DataGridViewRow fila = tiendas.SelectedRows[0];
                denominacion.Text = fila.Cells["denominacion"].Value.ToString();
                direccion.Text = fila.Cells["direccion"].Value.ToString();
                comboResponsable.Text = fila.Cells["responsable"].Value.ToString();
            }
        }

        private void registrarTienda_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(denominacion.Text) ||
                string.IsNullOrWhiteSpace(direccion.Text) ||
                comboResponsable.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos de registro son obligatorios", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                // Conexion.Ejecutar($"INSERT INTO tiendas VALUES ('{txtDenominacion.Text}', '{txtDireccion.Text}', '{comboResponsable.Text}')");

                MessageBox.Show("Registro realizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarListadoTiendas();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar tienda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
