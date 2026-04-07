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
using Ferreteria.Modelos;
using MySqlConnector;

namespace Ferreteria.Opciones_Admin
{ 
    public partial class VentanaVerDatosCuenta : Form

    {

        private void CargarDatosCuenta()
        {
            try
            {
                MySqlDataReader reader = Conexion.GetDatosCuenta(Usuario.UsuarioLogado);

                if (reader.Read())
                {
                    CampoNombre.Text = reader["nombre_apellidos"].ToString();
                    CampoUsuario.Text = reader["usuario"].ToString();
                    CampoTipo.Text = reader["tipo"].ToString();
                    CampoEstado.Text = reader["estado"].ToString();
                    CampoFecha.Text = reader["fecha_alta"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos.\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public VentanaVerDatosCuenta()
        {
            InitializeComponent();
            CargarDatosCuenta();

        }

       

        



        private void botonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                           "¿Desea cerrar sin guardar los cambios?",
                           "Confirmar",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
                this.Close();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {     // 1. Validar nombre obligatorio
            if (string.IsNullOrWhiteSpace(CampoNombre.Text))
            {
                MessageBox.Show("El nombre y apellidos es obligatorio.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CampoNombre.Focus();
                return;
            }

            // 2. ¿Quiere cambiar contraseña?
            bool cambiarPass = !string.IsNullOrWhiteSpace(CampoCon.Text) ||
                               !string.IsNullOrWhiteSpace(CampoConNueva.Text) ||
                               !string.IsNullOrWhiteSpace(CampoConCon.Text);

            string nuevaPass = null;

            if (cambiarPass)
            {
                // 2a. Pass actual no vacía
                if (string.IsNullOrWhiteSpace(CampoCon.Text))
                {
                    MessageBox.Show("Introduce tu contraseña actual.",
                                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CampoCon.Focus();
                    return;
                }

                // 2b. Verificar pass actual contra BD
                if (!Conexion.VerificarPass(Usuario.UsuarioLogado, CampoCon.Text))
                {
                    MessageBox.Show("La contraseña actual no es correcta.",
                                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CampoCon.Clear();
                    CampoCon.Focus();
                    return;
                }

                // 2c. Nueva pass no vacía
                if (string.IsNullOrWhiteSpace(CampoConNueva.Text))
                {
                    MessageBox.Show("Introduce la nueva contraseña.",
                                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CampoConNueva.Focus();
                    return;
                }

                // 2d. Confirmar que coinciden
                if (CampoConNueva.Text != CampoConCon.Text)
                {
                    MessageBox.Show("Las contraseñas nuevas no coinciden.",
                                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CampoConCon.Clear();
                    CampoConCon.Focus();
                    return;
                }

                nuevaPass = CampoConNueva.Text;
            }

            // 3. Ejecutar actualización
            bool ok = Conexion.ActualizarCuenta(Usuario.UsuarioLogado, CampoNombre.Text, nuevaPass);

            if (ok)
            {
                MessageBox.Show("Datos actualizados correctamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar campos de contraseña
                CampoCon.Clear();
                CampoConNueva.Clear();
                CampoConCon.Clear();
            }
            else
            {
                MessageBox.Show("No se pudieron actualizar los datos.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

                  

        private void campoUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CampoNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
