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
    public partial class VentanaVerListadoArticulosOferta : Form
    {
        private string codigoSeleccionado = "";

        public VentanaVerListadoArticulosOferta()
        {
            InitializeComponent();
            ConfigurarInterfazInicial();
        }
        private void VentanaVerListadoArticulosOferta_Load(object sender, EventArgs e)
        {
            CargarArticulosEnOferta();
        }

        private void ConfigurarInterfazInicial()
        {
            panelDatos.Visible = false;

            articulos.AutoGenerateColumns = false;
        }

        private void CargarArticulosEnOferta()
        {
            //"SELECT codProducto, nombre, categoria, precio_venta, oferta FROM producto WHERE oferta = 'SI'"
            // articulos.DataSource = Conexion.EjecutarConsulta(sql);
        }

        private void articulos_SelectionChanged(object sender, EventArgs e)
        {
            if (articulos.SelectedRows.Count > 0)
            {
                panelDatos.Visible = true;

                codigoSeleccionado = articulos.SelectedRows[0].Cells["codProducto"].Value.ToString();

                CargarDetalleProducto(codigoSeleccionado);
            }
        }

        private void CargarDetalleProducto(string codigo)
        {
            //campoCodigo.Text = ...;
            //nombre.Text = ...;
            //descripcion.Text = ...;
            //stock.Text = ...comboOferta.SelectedItem = ... (Valores ENUM 'SI'/'NO');
        }

        private void guardarOferta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codigoSeleccionado)) return;

            try
            {
                string nuevoEstadoOferta = comboOferta.SelectedItem.ToString();


                MessageBox.Show("Estado de oferta actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarArticulosEnOferta();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cerrarDetalle_Click(object sender, EventArgs e)
        {
            panelDatos.Visible = false;
            articulos.ClearSelection();
            codigoSeleccionado = "";
        }
    }
}
