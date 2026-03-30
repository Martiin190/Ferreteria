using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.Opciones_Admin
{
    public partial class VentanaRegistrarArticulo : Form
    {
        public VentanaRegistrarArticulo()
        {
            InitializeComponent();

            radioDestacadoNo.Checked = true;
            radioOfertaNo.Checked = true;
        }

        private void campoPrecioCompra_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(campoPrecioCompra.Text, out double precioCompra))
            {
                double precioVenta = (precioCompra * 1.30) * 1.21;
                campoPrecioVenta.Text = precioVenta.ToString("F2");
            }
            else
            {
                campoPrecioVenta.Clear();
            }
        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(campoCodigo.Text) ||
                string.IsNullOrWhiteSpace(campoNombre.Text) ||
                comboCategoria.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(campoPrecioCompra.Text) ||
                string.IsNullOrWhiteSpace(campoStock.Text) ||
                comboOrigen.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos de registro son obligatorios.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(campoPrecioCompra.Text, out double precioCompra) ||
                !double.TryParse(campoPrecioVenta.Text, out double precioVenta) ||
                !int.TryParse(campoStock.Text, out int stock))
            {
                MessageBox.Show("Datos numéricos inválidos.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection("TU_CADENA_DE_CONEXION"))
                {
                    conn.Open();

                    string query = @"INSERT INTO producto 
                (codProducto, nombre, categoria, descripcion, precio_compra, precio_venta, stock, origen, destacado, oferta, fecha_alta) 
                VALUES 
                (@cod, @nom, @cat, @desc, @pComp, @pVenta, @stock, @orig, @dest, @ofer, @fecha)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@cod", campoCodigo.Text);
                    cmd.Parameters.AddWithValue("@nom", campoNombre.Text);
                    cmd.Parameters.AddWithValue("@cat", comboCategoria.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@desc", campoDescripcion.Text);
                    cmd.Parameters.AddWithValue("@pComp", precioCompra);
                    cmd.Parameters.AddWithValue("@pVenta", precioVenta);
                    cmd.Parameters.AddWithValue("@stock", stock);
                    cmd.Parameters.AddWithValue("@orig", comboOrigen.SelectedItem.ToString());
                 
                    cmd.Parameters.AddWithValue("@dest", radioDestacadoSi.Checked ? "SI" : "NO");
                    cmd.Parameters.AddWithValue("@ofer", radioOfertaSi.Checked ? "SI" : "NO");

                    cmd.Parameters.AddWithValue("@fecha", fechaAlta.Value.Date);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro realizado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message,
                    "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            campoCodigo.Clear();
            campoNombre.Clear();
            campoDescripcion.Clear();
            campoPrecioCompra.Clear();
            campoPrecioVenta.Clear();
            campoStock.Clear();

            comboCategoria.SelectedIndex = -1;
            comboOrigen.SelectedIndex = -1;

            radioDestacadoNo.Checked = true;
            radioOfertaNo.Checked = true;

            fechaAlta.Value = DateTime.Now;
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
