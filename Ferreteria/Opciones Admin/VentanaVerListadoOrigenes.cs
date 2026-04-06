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
    public partial class VentanaVerListadoOrigenes : Form
    {
        public VentanaVerListadoOrigenes()
        {
            InitializeComponent();
            this.Load += VentanaVerListadoOrigenes_Load;
            this.articulos.SelectionChanged += articulos_SelectionChanged;
            ConfigurarVentana();
        }

        private void VentanaVerListadoOrigenes_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void ConfigurarVentana()
        {
            panelDatos.Visible = false;
            articulos.ReadOnly = true;
            articulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            articulos.MultiSelect = false;
            articulos.AllowUserToAddRows = false;
            articulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ActualizarGrid()
        {
            DataTable dt = Conexion.VerListadoOrigenes();

            if (dt != null)
                articulos.DataSource = dt;

            comboOrigen.DataSource = new DataTable(); // limpia para evitar sincronización
            comboOrigen.DataSource = dt;
            comboOrigen.DisplayMember = "Denominacion";
            comboOrigen.ValueMember = "Denominacion";
            comboOrigen.SelectedIndex = -1;
        }

        private void articulos_SelectionChanged(object sender, EventArgs e)
        {
            if (articulos.SelectedRows.Count > 0)
            {
                DataRow fila = ((DataRowView)articulos.SelectedRows[0].DataBoundItem).Row;

                denominacion.Text = fila["Denominacion"].ToString();
                descripcion.Text = fila["Descripcion"].ToString();

                panelDatos.Visible = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(denominacion.Text) || string.IsNullOrWhiteSpace(descripcion.Text))
            {
                MessageBox.Show("Todos los campos de registro son obligatorios", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool ok = Conexion.RegistrarOrigen(denominacion.Text.Trim(), descripcion.Text.Trim());

            if (ok)
            {
                MessageBox.Show("Registro realizado correctamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarGrid();
                LimpiarInterfaz();
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            LimpiarInterfaz();
        }

        private void LimpiarInterfaz()
        {
            denominacion.Clear();
            descripcion.Clear();
            articulos.ClearSelection();
            panelDatos.Visible = false;
        }
    }
}
