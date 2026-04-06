using Ferreteria.bbdd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Ferreteria.Opciones_Admin
{
    public partial class VentanaVerListadoArticulosDestacados : Form
    {
        private string _codigoSeleccionado = string.Empty;

        public VentanaVerListadoArticulosDestacados()
        {
            InitializeComponent();
            // Vinculamos eventos manualmente por seguridad
            this.articulos.SelectionChanged += articulos_SelectionChanged;
            this.comboSeleccione.SelectedIndexChanged += comboSeleccione_SelectedIndexChanged;
            this.Load += VentanaVerListadoArticulosDestacados_Load;
        }

        private void VentanaVerListadoArticulosDestacados_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarArticulos();
            panelDatos.Visible = false;
        }

        private void ConfigurarDataGridView()
        {
            articulos.ReadOnly = true;
            articulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            articulos.MultiSelect = false;
            articulos.AllowUserToAddRows = false;
            articulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarArticulos()
        {
            DataTable dt = Conexion.VerListadoArticulosDestacados();

            if (dt != null)
            {
                articulos.DataSource = dt;

                comboSeleccione.DataSource = dt;
                comboSeleccione.DisplayMember = "nombre";
                comboSeleccione.ValueMember = "codProducto";
                comboSeleccione.SelectedIndex = -1;
            }
        }

        private void CargarDetalle(DataRow fila)
        {
            campoCodigo.Text = fila["codProducto"].ToString();
            nombre.Text = fila["nombre"].ToString();
            categoria.Text = fila["categoria"].ToString();
            descripcion.Text = fila["descripcion"].ToString();
            precioCompra.Text = fila["precio_compra"].ToString();
            precioVenta.Text = fila["precio_venta"].ToString();
            stock.Text = fila["stock"].ToString();
            origen.Text = fila["origen"].ToString();
            oferta.Text = fila["oferta"].ToString();

            if (fila["fecha_alta"] != DBNull.Value)
                fechaAlta.Text = Convert.ToDateTime(fila["fecha_alta"]).ToShortDateString();

            panelDatos.Visible = true;
        }

        private void articulos_SelectionChanged(object sender, EventArgs e)
        {
            if (articulos.SelectedRows.Count > 0)
            {
                DataRowView fila = (DataRowView)articulos.SelectedRows[0].DataBoundItem;
                CargarDetalle(fila.Row);
            }
        }

        private void comboSeleccione_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSeleccione.SelectedValue != null && comboSeleccione.Focused)
            {
                DataRowView fila = (DataRowView)comboSeleccione.SelectedItem;
                CargarDetalle(fila.Row);
            }
        }

        private void LimpiarDetalle()
        {
            _codigoSeleccionado = string.Empty;
            campoCodigo.Clear();
            nombre.Clear();
            categoria.Clear();
            descripcion.Clear();
            precioCompra.Clear();
            precioVenta.Clear();
            stock.Clear();
            origen.Clear();
            oferta.Clear();
            fechaAlta.Clear();
            panelDatos.Visible = false;
        }
    }
}

