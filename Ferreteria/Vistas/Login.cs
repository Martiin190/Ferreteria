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
using Ferreteria.Vistas;

namespace Ferreteria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tipo = Conexion.Login(CampoUsuario.Text, CampoPass.Text);

            if (tipo != null)
            {
                Conexion.RegistrarAcceso(CampoUsuario.Text);

                if (tipo == "admin")
                {
                    VPAdmin fp = new VPAdmin();
                    fp.Show();
                }
                else
                {
                    VPUser fp = new VPUser();
                    fp.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos, o usuario bloqueado.");
            }
        }
    
        }
        }
    

