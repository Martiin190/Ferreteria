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
            }
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_codigoSeleccionado)) return;

            try
            {
                Conexion.conectar(); // Ahora Conexion.conn ya no dará error
                string sql = "DELETE FROM producto WHERE codProducto = @cod";
                MySqlCommand cmd = new MySqlCommand(sql, Conexion.conn);
                cmd.Parameters.AddWithValue("@cod", _codigoSeleccionado);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Eliminado correctamente");
                CargarDatos(); // Refrescar la lista
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Conexion.cerrar(); }
        }
    }
}
      