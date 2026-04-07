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

            if (string.IsNullOrWhiteSpace(campoCodigo.Text) || comboCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Faltan campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double.TryParse(campoPrecioCompra.Text, out double pComp);
            double.TryParse(campoPrecioVenta.Text, out double pVenta);
            int.TryParse(campoStock.Text, out int stock);

            bool exito = Conexion.RegistrarArticulo(
                campoCodigo.Text,
                campoNombre.Text,
                comboCategoria.Text,
                campoDescripcion.Text,
                pComp,
                pVenta,
                stock,
                comboOrigen.Text,
                radioDestacadoSi.Checked ? "SI" : "NO",
                radioOfertaSi.Checked ? "SI" : "NO",
                fechaAlta.Value.Date
            );

            if (exito)
            {
                MessageBox.Show("Registro realizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
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
    }
}
