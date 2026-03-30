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
    public partial class VentanaVerListadoArticulosDestacados : Form
    {
        public VentanaVerListadoArticulosDestacados()
        {
            InitializeComponent();
        }

        private string _codigoSeleccionado = string.Empty;

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
            try
            {
                using (MySqlConnection conn = new MySqlConnection())
                {
                    conn.Open();
                    string query = @"SELECT codProducto, nombre, categoria, precio_venta, destacado
                                     FROM producto ORDER BY nombre ASC";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dt.Columns["codProducto"].ColumnName = "Código";
                    dt.Columns["nombre"].ColumnName = "Nombre";
                    dt.Columns["categoria"].ColumnName = "Categoría";
                    dt.Columns["precio_venta"].ColumnName = "Precio venta";
                    dt.Columns["destacado"].ColumnName = "Destacado";

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
            panelDatos.Visible = true;
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
                        categoria.Text = reader["categoria"].ToString();
                        nombre.Text = reader["nombre"].ToString();
                        descripcion.Text = reader["descripcion"].ToString();
                        precioCompra.Text = Convert.ToDouble(reader["precio_compra"]).ToString("F2");
                        precioVenta.Text = Convert.ToDouble(reader["precio_venta"]).ToString("F2");
                        stock.Text = reader["stock"].ToString();
                        origen.Text = reader["origen"].ToString();
                        oferta.Text = reader["oferta"].ToString();
                        fechaAlta.Text = Convert.ToDateTime(reader["fecha_alta"]).ToString("dd/MM/yyyy");

                        string valorDestacado = reader["destacado"].ToString();
                        comboSeleccione.SelectedItem = valorDestacado;
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

            if (comboSeleccione.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un valor para el campo Destacado.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(
                        "UPDATE producto SET destacado = @destacado WHERE codProducto = @codigo", conn);
                    cmd.Parameters.AddWithValue("@destacado", comboSeleccione.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@codigo", _codigoSeleccionado);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Valor de destacado actualizado correctamente.",
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
                $"¿Estás seguro de que deseas eliminar el artículo \"{nombre.Text}\"?\nEsta acción no se puede deshacer.",
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

                panelDatos.Visible = false;
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
            categoria.Text = string.Empty;
            nombre.Text = string.Empty;
            descripcion.Text = string.Empty;
            precioCompra.Text = string.Empty;
            precioVenta.Text = string.Empty;
            stock.Text = string.Empty;
            origen.Text = string.Empty;
            oferta.Text = string.Empty;
            fechaAlta.Text = string.Empty;
            comboSeleccione.SelectedIndex = -1;
        }
    }
}
