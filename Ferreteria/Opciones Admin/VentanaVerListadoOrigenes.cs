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
    public partial class VentanaVerListadoOrigenes : Form
    {
        public VentanaVerListadoOrigenes()
        {
            InitializeComponent();
        }

        private void VentanaVerListadoOrigenes_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void ConfigurarVentana()
        {
            panelDatos.Visible = false;
        }

        private void ActualizarGrid()
        {
            string sql = "SELECT origen AS Denominacion, descripcion AS Descripcion FROM origen";
            // articulos.DataSource = Conexion.ObtenerTablas(sql);
        }

        private void articulos_SelectionChanged(object sender, EventArgs e)
        {
            if (articulos.SelectedRows.Count > 0)
            {
                panelDatos.Visible = true;

                denominacion.Text = articulos.SelectedRows[0].Cells["Denominacion"].Value.ToString();
                descripcion.Text = articulos.SelectedRows[0].Cells["Descripcion"].Value.ToString();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(denominacion.Text) || string.IsNullOrWhiteSpace(descripcion.Text))
            {
                MessageBox.Show("Todos los campos de registro son obligatorios", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            { 
                string sql = $"INSERT INTO origen (origen, descripcion) VALUES ('{denominacion.Text}', '{descripcion.Text}')";
                // Conexion.EjecutarComando(sql);

                MessageBox.Show("Registro realizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ActualizarGrid();
                LimpiarInterfaz();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
