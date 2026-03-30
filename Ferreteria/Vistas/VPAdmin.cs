using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreteria.Opciones_Admin;

namespace Ferreteria.Vistas
{
    public partial class VPAdmin : Form
    {
        public VPAdmin()
        {
            InitializeComponent();
        }

        private void VPAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            VentanaVerListadoTiendas ventana = new VentanaVerListadoTiendas();
            ventana.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            VentanaVerListadoOrigenes ventana = new VentanaVerListadoOrigenes();
            ventana.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            VentanaVerListadoCategorias ventana = new VentanaVerListadoCategorias();
            ventana.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            VentanaVerListadoArticulosOferta ventana = new VentanaVerListadoArticulosOferta();
            ventana.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VentanaVerListadoArticulos ventana = new VentanaVerListadoArticulos();
            ventana.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VentanaVerDatosCuenta ventana = new VentanaVerDatosCuenta();
            ventana.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentanaVerListadoUsuarios ventana = new VentanaVerListadoUsuarios();
            ventana.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentanaRegistrarUsuario ventana = new VentanaRegistrarUsuario();
            ventana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaRegistrarArticulo ventana = new VentanaRegistrarArticulo();
            ventana.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VentanaVerListadoArticulosDestacados ventana = new VentanaVerListadoArticulosDestacados();
            ventana.Show();
        }
    }
}
