using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.Opciones_Admin
{
    public partial class VentanaVerListadoUsuarios : Form
    {

        private int idUsuarioSeleccionado = -1;

        public VentanaVerListadoUsuarios()
        {
            InitializeComponent();
            ConfiguracionProyecto();
        }

        private void VentanaVerListadoUsuarios_Load(object sender, EventArgs e)
        {
            RefrescarListaUsuarios();
        }

        private void ConfiguracionProyecto()
        {
            panelDatos.Visible = false;

            comboTipo.Items.AddRange(new string[] { "admin", "user" });
            comboEstado.Items.AddRange(new string[] { "activo", "bloqueado" });
        }

        private void RefrescarListaUsuarios()
        {
            // Consulta: "SELECT idUsuario, nombre_apellidos, tienda, usuario, tipo, estado, fecha_alta FROM usuarios"
            // usuarios.DataSource = Conexion.EjecutarConsulta(sql);
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (usuarios.SelectedRows.Count > 0)
            {
                panelDatos.Visible = true;

                DataGridViewRow fila = usuarios.SelectedRows[0];
                idUsuarioSeleccionado = Convert.ToInt32(fila.Cells["idUsuario"].Value);

                nombre.Text = fila.Cells["nombre_apellidos"].Value.ToString();
                usuario.Text = fila.Cells["usuario"].Value.ToString();
                fechaAlta.Text = fila.Cells["fecha_alta"].Value.ToString();

                comboTienda.Text = fila.Cells["tienda"].Value.ToString();
                comboTipo.SelectedItem = fila.Cells["tipo"].Value.ToString();
                comboEstado.SelectedItem = fila.Cells["estado"].Value.ToString();
            }
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado == -1) return;

            if (string.IsNullOrWhiteSpace(comboTienda.Text) || comboTipo.SelectedIndex == -1 || comboEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Los campos Tienda, Tipo y Estado son obligatorios para la actualización.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sql = $"UPDATE usuarios SET tienda='{comboTienda.Text}', tipo='{comboTipo.Text}', estado='{comboEstado.Text}' WHERE idUsuario={idUsuarioSeleccionado}";


                MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefrescarListaUsuarios();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            nombre.Clear();
            usuario.Clear();
            comboTienda.SelectedIndex = -1;
            comboTipo.SelectedIndex = -1;
            comboEstado.SelectedIndex = -1;
            idUsuarioSeleccionado = -1;
            usuarios.ClearSelection();

            panelDatos.Visible = false;
        }
    }
}
