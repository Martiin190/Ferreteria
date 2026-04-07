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

namespace Ferreteria.Opciones
{
    public partial class VentanaListadoTotalArticulos : Form
    {
        public VentanaListadoTotalArticulos()
        {
            InitializeComponent();
            CargarDatos();

        }
        private void CargarDatos()
        {
            string sql = "SELECT codProducto, nombre, categoria, precio_venta FROM producto";

            dataGridView1.DataSource = Conexion.GetTabla(sql);

            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns["codProducto"].HeaderText = "Código";
            dataGridView1.Columns["nombre"].HeaderText = "Nombre";
            dataGridView1.Columns["categoria"].HeaderText = "Categoría";
            dataGridView1.Columns["precio_venta"].HeaderText = "Precio Venta";
        }
        private void LimpiarDetalle()
        {
            CampoCodigo.Text = "";
            CampoNombre.Text = "";
            CampoCategoria.Text = "";
            CampoDescripcion.Text = "";
            CampoPrecioCompra.Text = "";
            CampoPrecioVenta.Text = "";
            CampoStock.Text = "";
            CampoOferta.Text = "";
            CampoDestacado.Text = "";
            CampoOferta.Text = "";
            CampoFecha.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            LimpiarDetalle();

            string codigo = dataGridView1.Rows[e.RowIndex]
                            .Cells["codProducto"].Value.ToString();

            string sql = "SELECT * FROM producto WHERE codProducto = '" + codigo + "'";
            DataTable dt = Conexion.GetTabla(sql);

            if (dt.Rows.Count > 0)
            {
                DataRow fila = dt.Rows[0];

                CampoCodigo.Text = fila["codProducto"].ToString();
                CampoNombre.Text = fila["nombre"].ToString();
                CampoCategoria.Text = fila["categoria"].ToString();
                CampoDescripcion.Text = fila["descripcion"].ToString();
                CampoPrecioCompra.Text = fila["precio_compra"].ToString();
                CampoPrecioVenta.Text = fila["precio_venta"].ToString();
                CampoStock.Text = fila["stock"].ToString();
                CampoOferta.Text = fila["origen"].ToString();
                CampoDestacado.Text = fila["destacado"].ToString();
                CampoOferta.Text = fila["oferta"].ToString();
                CampoFecha.Text = fila["fecha_alta"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CampoCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarDetalle();
        }
    }
}
