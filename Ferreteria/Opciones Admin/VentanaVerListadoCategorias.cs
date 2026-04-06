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
    public partial class VentanaVerListadoCategorias : Form
    {
        public VentanaVerListadoCategorias()
        {
            InitializeComponent();
            this.Load += VentanaVerListadoCategorias_Load;
            this.articulos.SelectionChanged += articulos_SelectionChanged;
            ConfiguracionInicial();
        }
        private void VentanaVerListadoCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void ConfiguracionInicial()
        {
            panelDatos.Visible = false;
            articulos.ReadOnly = true;
            articulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            articulos.MultiSelect = false;
            articulos.AllowUserToAddRows = false;
            articulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void CargarCategorias()
        {
            DataTable dt = Conexion.VerListadoCategorias();

            if (dt != null)
                articulos.DataSource = dt;

            comboCategoria.DataSource = new DataTable(); // limpia primero para evitar conflicto
            comboCategoria.DataSource = dt;
            comboCategoria.DisplayMember = "Denominacion";
            comboCategoria.ValueMember = "Denominacion";
            comboCategoria.SelectedIndex = -1;
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

        private void registrarCategoria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(denominacion.Text) || string.IsNullOrWhiteSpace(descripcion.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool ok = Conexion.RegistrarCategoria(denominacion.Text.Trim(), descripcion.Text.Trim());

            if (ok)
            {
                MessageBox.Show("Registro realizado correctamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCategorias();
                LimpiarCampos();
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            denominacion.Clear();
            descripcion.Clear();
            articulos.ClearSelection();

            panelDatos.Visible = false;
        }
    }
}
