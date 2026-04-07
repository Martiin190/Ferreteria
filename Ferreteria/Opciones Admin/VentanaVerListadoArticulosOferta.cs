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

        public VentanaVerListadoArticulosOferta()
        {
            InitializeComponent();
            CargarDatos();
        }
        private void CargarDatos()
        {
            string sql = "SELECT codProducto, nombre, categoria, precio_venta, oferta " +
                 "FROM producto WHERE oferta = 'SI'";

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
            dataGridView1.Columns["Oferta"].HeaderText = "Oferta";

            // Cargar opciones del ComboBox
            ComboOferta.Items.Clear();
            ComboOferta.Items.Add("SI");
            ComboOferta.Items.Add("NO");
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
            CampoDestacado.Text = "";
            CampoFecha.Text = "";
            ComboOferta.SelectedIndex = -1;
        }




        private void articulos_SelectionChanged(object sender, EventArgs e)
        {
        }
        private void VentanaVerListadoArticulosOferta_Load(object sender, EventArgs e)
        {
            
        }

        private void ConfigurarDataGridView()
        {
            
        }

       

      

       
        private void cerrarDetalle_Click(object sender, EventArgs e)
        {
            
        }

        private void CampoCodigo_TextChanged(object sender, EventArgs e)
        {

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
                CampoOrigen.Text = fila["origen"].ToString();
                CampoDestacado.Text = fila["oferta"].ToString();
                CampoFecha.Text = fila["fecha_alta"].ToString();

                // Seleccionar valor actual en el ComboBox
                ComboOferta.SelectedItem = fila["destacado"].ToString();
            }

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
            if (ComboOferta.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un valor para oferta.");
                return;
            }

            string codigo = CampoCodigo.Text;
            string nuevoValor = ComboOferta.SelectedItem.ToString();

            // Confirmar acción
            DialogResult confirm = MessageBox.Show(
                "¿Cambiar destacado a " + nuevoValor + "?",
                "Confirmar",
                MessageBoxButtons.YesNo
            );

            if (confirm == DialogResult.Yes)
            {
                Conexion.CambiarOferta(codigo, nuevoValor);
                MessageBox.Show("✅ Oferta actualizado correctamente.");
                CargarDatos();   // Refresca el DataGridView
                LimpiarDetalle(); // Limpia el detalle
            }
        }
    }
}

