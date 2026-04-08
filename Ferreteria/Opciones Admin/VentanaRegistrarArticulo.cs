using Ferreteria.bbdd;
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
            this.Load += VentanaRegistrarArticulo_Load;
            radioDestacadoNo.Checked = true;
            radioOfertaNo.Checked = true;
        }

        private void VentanaRegistrarArticulo_Load(object sender, EventArgs e)
        {
            CargarCombos();
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
            // 1. VALIDACIÓN (Lo que ya tenías, pero ampliado a todos los campos obligatorios RI2)
            if (string.IsNullOrWhiteSpace(campoCodigo.Text) ||
                string.IsNullOrWhiteSpace(campoNombre.Text) ||
                string.IsNullOrWhiteSpace(campoDescripcion.Text) ||
                string.IsNullOrWhiteSpace(campoPrecioCompra.Text) ||
                string.IsNullOrWhiteSpace(campoStock.Text) ||
                comboCategoria.SelectedIndex == -1 ||
                comboOrigen.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. RECOGIDA DE VALORES (Especialmente los RadioButtons)
            string destacado = radioDestacadoSi.Checked ? "SI" : "NO";
            string oferta = radioOfertaSi.Checked ? "SI" : "NO";

            // Convertimos precios y stock (usamos TryParse para evitar bloqueos si ponen letras)
            double pCompra = double.Parse(campoPrecioCompra.Text);
            double pVenta = double.Parse(campoPrecioVenta.Text);
            int stock = int.Parse(campoStock.Text);

            // 3. LLAMADA A LA BASE DE DATOS
            bool exito = Conexion.RegistrarArticulo(
                campoCodigo.Text.Trim(),
                campoNombre.Text.Trim(),
                comboCategoria.Text,
                campoDescripcion.Text.Trim(),
                pCompra,
                pVenta,
                stock,
                comboOrigen.Text,
                destacado,
                oferta,
                fechaAlta.Value.Date
            );

            // 4. RESPUESTA AL USUARIO (RI2)
            if (exito)
            {
                MessageBox.Show("Artículo registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos(); // Limpiamos para el siguiente registro
            }
            else
            {
                MessageBox.Show("No se pudo registrar. Revisa si el código de producto ya existe.", "Error");
            }
        }



        private void CargarCombos()
        {
            DataTable dtCat = Conexion.VerListadoCategorias();
            if (dtCat != null)
            {
                comboCategoria.DataSource = dtCat;
                comboCategoria.DisplayMember = "Denominacion";
                comboCategoria.ValueMember = "Denominacion";
                comboCategoria.SelectedIndex = -1;
            }
        
            DataTable dtOri = Conexion.VerListadoOrigenes();
            if (dtOri != null)
            {
                comboOrigen.DataSource = dtOri;
                comboOrigen.DisplayMember = "Denominacion"; 
                comboOrigen.ValueMember = "Denominacion";
                comboOrigen.SelectedIndex = -1;
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

        private void campoDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
