using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreteria.Opciones_User;

namespace Ferreteria.Vistas
{
    public partial class VPUser : Form
    {
        public VPUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaDatosCuenta ventana = new VentanaDatosCuenta();
            ventana.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentanaListadoArtículosDestacados ventana = new VentanaListadoArtículosDestacados();
            ventana.Show();
        }
    }
}
