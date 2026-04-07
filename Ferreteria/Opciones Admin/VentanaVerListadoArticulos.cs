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
    public partial class VentanaVerListadoArticulos : Form
    {

        private string _codigoSeleccionado = string.Empty;

        public VentanaVerListadoArticulos()
        {
            InitializeComponent();
            // Si no te carga al abrir, añade estas líneas aquí para forzar los eventos:
            this.Load += new EventHandler(VentanaVerListadoArticulos_Load);
            this.articulos.SelectionChanged += new EventHandler(articulos_SelectionChanged);
        }

        private void VentanaVerListadoArticulos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            // Usamos el método de la clase Conexion
            string sql = "SELECT codProducto, nombre, categoria, precio_venta FROM producto";
            DataTable dt = Conexion.GetTabla(sql);

            if (dt != null)
            {
                // Carga la tabla (DataGridView)
                articulos.DataSource = dt;

                // Carga el ComboBox
                comboArticulo.DataSource = dt;
                comboArticulo.DisplayMember = "nombre";
                comboArticulo.ValueMember = "codProducto";
                comboArticulo.SelectedIndex = -1;
            }
        }

        private void articulos_SelectionChanged(object sender, EventArgs e)
        {
            if (articulos.SelectedRows.Count > 0)
            {
                // Cogemos el código de la fila seleccionada
                string codigo = articulos.SelectedRows[0].Cells["codProducto"].Value.ToString();
                CargarDetalle(codigo);
            }
        }

        private void CargarDetalle(string codigo)
        {
            _codigoSeleccionado = codigo;
            DataTable dt = Conexion.VerListadoArticulos(codigo);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];

                // Cargamos los datos
                campoCodigo.Text = r["codProducto"].ToString();
                campoNombre.Text = r["nombre"].ToString();
                campoCategoria.Text = r["categoria"].ToString();
                campoDescripcion.Text = r["descripcion"].ToString();
                campoPrecioCompra.Text = r["precio_compra"].ToString();
                campoPrecioVenta.Text = r["precio_venta"].ToString();
                campoStock.Text = r["stock"].ToString();
                campoOrigen.Text = r["origen"].ToString();
                campoDestacado.Text = r["destacado"].ToString();
                campoOferta.Text = r["oferta"].ToString();
                campoFechaAlta.Text = Convert.ToDateTime(r["fecha_alta"]).ToShortDateString();

                // HABILITAMOS la edición solo para estos dos campos (Requerimiento)
                campoNombre.ReadOnly = false;
                campoNombre.Enabled = true;

                campoDescripcion.ReadOnly = false;
                campoDescripcion.Enabled = true;

                // Opcional: Cambiar el color de fondo para que el usuario sepa que puede escribir
                campoNombre.BackColor = Color.White;
                campoDescripcion.BackColor = Color.White;
            }
        }

        private void botonEliminar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_codigoSeleccionado))
            {
                MessageBox.Show("Selecciona un producto para eliminar.", "Aviso");
                return;
            }

            // Confirmación de acción (Requerimiento RI2 del PDF)
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar el producto " + _codigoSeleccionado + "?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Llamamos al método que acabamos de crear en Conexion
                if (Conexion.EliminarProducto(_codigoSeleccionado))
                {
                    MessageBox.Show("Producto eliminado correctamente.", "Éxito");
                    _codigoSeleccionado = string.Empty;

                    CargarDatos();    // Refresca el DataGridView
                    LimpiarCampos();  // Vacía los TextBox de detalles
                }
            }
        }

        private void botonActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_codigoSeleccionado))
            {
                MessageBox.Show("Seleccione un producto de la lista.");
                return;
            }

            // Validación RI2: Nombre obligatorio
            if (string.IsNullOrWhiteSpace(campoNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

            // Llamamos al método de Conexion (debes tenerlo creado en Conexion.cs)
            bool exito = Conexion.ActualizarArticulos(
                _codigoSeleccionado,
                campoNombre.Text.Trim(),
                campoDescripcion.Text.Trim()
            );

            if (exito)
            {
                MessageBox.Show("Nombre y Descripción actualizados correctamente.", "Éxito");
                CargarDatos(); // Refresca el DataGridView para ver el nuevo nombre
            }
        }

        public void LimpiarCampos() {
            campoCodigo.Text = "";
            campoNombre.Text = "";
            campoCategoria.Text = "";
            campoDescripcion.Text = "";
            campoPrecioCompra.Text = "";
            campoPrecioVenta.Text = "";
            campoStock.Text = "";
            campoOrigen.Text = "";
            campoDestacado.Text = "";
            campoOferta.Text = "";
            campoFechaAlta.Text = "";
        }
    }
}
      