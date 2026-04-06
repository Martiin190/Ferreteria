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
    public partial class VentanaVerListadoArticulosOferta : Form
    {
        private string codigoSeleccionado = "";

        public VentanaVerListadoArticulosOferta()
        {
            InitializeComponent();
            this.Load += VentanaVerListadoArticulosOferta_Load;
            this.articulos.SelectionChanged += articulos_SelectionChanged;
            ConfigurarDataGridView();
        }
        private void articulos_SelectionChanged(object sender, EventArgs e)
        {
            if (articulos.SelectedRows.Count > 0)
            {
                codigoSeleccionado = articulos.SelectedRows[0].Cells["codProducto"].Value.ToString();
                CargarDetalleProducto(codigoSeleccionado);
            }
        }
        private void VentanaVerListadoArticulosOferta_Load(object sender, EventArgs e)
        {
            CargarArticulosEnOferta();
        }

        private void ConfigurarDataGridView()
        {
            articulos.ReadOnly = true;
            articulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            articulos.MultiSelect = false;
            articulos.AllowUserToAddRows = false;
            articulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarArticulosEnOferta()
        {
            DataTable dt = Conexion.VerListadoArticulosEnOferta();

            if (dt != null)
            {
                articulos.DataSource = dt;

                comboOferta.DataSource = dt;
                comboOferta.DisplayMember = "nombre";
                comboOferta.ValueMember = "codProducto";
                comboOferta.SelectedIndex = -1;
            }
        }

        private void CargarDetalleProducto(string codigo)
        {
            if (articulos.SelectedRows.Count == 0) return;

            DataRow fila = ((DataRowView)articulos.SelectedRows[0].DataBoundItem).Row;

            campoCodigo.Text = fila["codProducto"].ToString();
            categoria.Text = fila["categoria"].ToString();
            nombre.Text = fila["nombre"].ToString();
            descripcion.Text = fila["descripcion"].ToString();
            stock.Text = fila["stock"].ToString();
            origen.Text = fila["origen"].ToString();
            destacado.Text = fila["destacado"].ToString();

            if (fila["fecha_alta"] != DBNull.Value)
                fechaAlta.Text = Convert.ToDateTime(fila["fecha_alta"]).ToString("dd/MM/yyyy");

            comboOferta.SelectedItem = fila["oferta"].ToString();

            panelDatos.Visible = true;
        }

        private void guardarOferta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codigoSeleccionado)) return;

            try
            {
                string nuevoEstadoOferta = comboOferta.SelectedItem.ToString();

                bool ok = Conexion.ActualizarOferta(codigoSeleccionado, nuevoEstadoOferta);

                if (ok)
                {
                    MessageBox.Show("Estado de oferta actualizado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarArticulosEnOferta();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
