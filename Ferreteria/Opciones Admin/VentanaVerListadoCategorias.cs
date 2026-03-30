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
    public partial class VentanaVerListadoCategorias : Form
    {
        public VentanaVerListadoCategorias()
        {
            InitializeComponent();
        }

        private void VentanaVerListadoCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void ConfiguracionInicial()
        {
            panelDatos.Visible = false;


            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen; 
            this.MaximizeBox = false;
        }

        private void CargarCategorias()
        {
            string sql = "SELECT categoria AS Denominacion, descripcion AS Descripcion FROM categorias";
            //articulos.DataSource = Conexion.ObtenerDatos(sql);
        }

        private void dgvCategorias_SelectionChanged(object sender, EventArgs e)
        {
            if (articulos.SelectedRows.Count > 0)
            {
                panelDatos.Visible = true;

                DataGridViewRow fila = articulos.SelectedRows[0];
                denominacion.Text = fila.Cells["Denominacion"].Value.ToString();
                descripcion.Text = fila.Cells["Descripcion"].Value.ToString();
            }
        }

        private void btnRegistrarCategoria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(denominacion.Text) || string.IsNullOrWhiteSpace(descripcion.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                 //Conexion.Ejecutar(denominacion.Text, descripcion.Text);

                MessageBox.Show("Registro realizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information); // 
                CargarCategorias();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
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
