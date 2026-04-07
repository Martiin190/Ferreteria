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

        public VentanaVerListadoArticulosDestacados()
        {
            InitializeComponent();
            CargarDatos();

        }
        private void CargarDatos()
        {
            string sql = "SELECT codProducto, nombre, categoria, precio_venta, destacado " +
                 "FROM producto WHERE destacado = 'SI'";

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
            dataGridView1.Columns["destacado"].HeaderText = "Destacado";

            // Cargar opciones del ComboBox
            ComboDestacado.Items.Clear();
            ComboDestacado.Items.Add("SI");
            ComboDestacado.Items.Add("NO");
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
            CampoOrigen.Text = "";
            CampoOferta.Text = "";
            CampoFecha.Text = "";
            ComboDestacado.SelectedIndex = -1;
        }
        private void VentanaVerListadoArticulosDestacados_Load(object sender, EventArgs e)
        {
            
        }

        

      

        private void articulos_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void comboSeleccione_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

      
        private void articulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                CampoOrigen.Text = fila["origen"].ToString();
                CampoOferta.Text = fila["oferta"].ToString();
                CampoFecha.Text = fila["fecha_alta"].ToString();

                // Seleccionar valor actual en el ComboBox
                ComboDestacado.SelectedItem = fila["destacado"].ToString();
            }
        }

        private void VentanaVerListadoArticulosDestacados_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Validar que hay artículo seleccionado
            if (CampoCodigo.Text == "")
            {
                MessageBox.Show("Selecciona un artículo primero.");
                return;
            }

            // Validar que hay valor en el combo
            if (ComboDestacado.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un valor para destacado.");
                return;
            }

            string codigo = CampoCodigo.Text;
            string nuevoValor = ComboDestacado.SelectedItem.ToString();

            // Confirmar acción
            DialogResult confirm = MessageBox.Show(
                "¿Cambiar destacado a " + nuevoValor + "?",
                "Confirmar",
                MessageBoxButtons.YesNo
            );

            if (confirm == DialogResult.Yes)
            {
                Conexion.CambiarDestacado(codigo, nuevoValor);
                MessageBox.Show("✅ Destacado actualizado correctamente.");
                CargarDatos();   // Refresca el DataGridView
                LimpiarDetalle(); // Limpia el detalle
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelDatos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ComboDestacado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void a_Click(object sender, EventArgs e)
        {

        }
    }
}


