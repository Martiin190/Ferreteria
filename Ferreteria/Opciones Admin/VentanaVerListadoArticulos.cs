using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ferreteria.Opciones_Admin
{
    public partial class VentanaVerListadoArticulos : Form
    {

        private string _codigoSeleccionado = string.Empty;
        public VentanaVerListadoArticulos()
        {
            InitializeComponent();
        }

        private void VentanaVerListadoArticulos_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarArticulos();
            LimpiarDetalle();
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
            try
            {
                using (MySqlConnection conn = new MySqlConnection())
                {
                    conn.Open();
                    string query = "SELECT codProducto, nombre, categoria, precio_venta FROM producto ORDER BY nombre ASC";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dt.Columns["codProducto"].ColumnName = "Código";
                    dt.Columns["nombre"].ColumnName = "Nombre";
                    dt.Columns["categoria"].ColumnName = "Categoría";
                    dt.Columns["precio_venta"].ColumnName = "Precio venta";

                    articulos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los artículos:\n" + ex.Message,
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (articulos.SelectedRows.Count == 0)
                return;

            string codigo = articulos.SelectedRows[0].Cells["Código"].Value.ToString();
            CargarDetalle(codigo);
        }

        private void CargarDetalle(string codigo)
        {
            _codigoSeleccionado = codigo;

            try
            {
                using (MySqlConnection conn = new MySqlConnection())
                {
                    conn.Open();
                    string query = @"SELECT codProducto, nombre, categoria, descripcion,
                                            precio_compra, precio_venta, stock, origen,
                                            destacado, oferta, fecha_alta
                                     FROM producto WHERE codProducto = @codigo";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        campoCodigo.Text = reader["codProducto"].ToString();
                        campoCategoria.Text = reader["categoria"].ToString();
                        campoNombre.Text = reader["nombre"].ToString();
                        campoDescripcion.Text = reader["descripcion"].ToString();
                        campoPrecioCompra.Text = Convert.ToDouble(reader["precio_compra"]).ToString("F2");
                        campoPrecioVenta.Text = Convert.ToDouble(reader["precio_venta"]).ToString("F2");
                        campoStock.Text = reader["stock"].ToString();
                        campoOrigen.Text = reader["origen"].ToString();
                        campoDestacado.Text = reader["destacado"].ToString();
                        campoOferta.Text = reader["oferta"].ToString();
                        campoFechaAlta.Text = Convert.ToDateTime(reader["fecha_alta"]).ToString("dd/MM/yyyy");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el detalle del artículo:\n" + ex.Message,
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_codigoSeleccionado))
            {
                MessageBox.Show("Selecciona un artículo de la lista antes de actualizar.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(campoNombre.Text) ||
                string.IsNullOrWhiteSpace(campoDescripcion.Text))
            {
                MessageBox.Show("Los campos Nombre y Descripción no pueden estar vacíos.",
                    "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(
                        "UPDATE producto SET nombre = @nombre, descripcion = @desc WHERE codProducto = @codigo", conn);
                    cmd.Parameters.AddWithValue("@nombre", campoNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@desc", campoDescripcion.Text.Trim());
                    cmd.Parameters.AddWithValue("@codigo", _codigoSeleccionado);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Artículo actualizado correctamente.",
                    "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarArticulos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el artículo:\n" + ex.Message,
                    "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_codigoSeleccionado))
            {
                MessageBox.Show("Selecciona un artículo de la lista antes de eliminar.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                $"¿Estás seguro de que deseas eliminar el artículo \"{campoNombre.Text}\"?\nEsta acción no se puede deshacer.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion != DialogResult.Yes)
                return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(
                        "DELETE FROM producto WHERE codProducto = @codigo", conn);
                    cmd.Parameters.AddWithValue("@codigo", _codigoSeleccionado);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Artículo eliminado correctamente.",
                    "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarDetalle();
                CargarArticulos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el artículo:\n" + ex.Message,
                    "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarDetalle()
        {
            _codigoSeleccionado = string.Empty;
            campoCodigo.Text = string.Empty;
            campoCategoria.Text = string.Empty;
            campoNombre.Text = string.Empty;
            campoDescripcion.Text = string.Empty;
            campoPrecioCompra.Text = string.Empty;
            campoPrecioVenta.Text = string.Empty;
            campoStock.Text = string.Empty;
            campoOrigen.Text = string.Empty;
            campoDestacado.Text = string.Empty;
            campoOferta.Text = string.Empty;
            campoFechaAlta.Text = string.Empty;
        }
    }
}
