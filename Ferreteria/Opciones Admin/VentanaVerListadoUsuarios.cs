using Ferreteria.bbdd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Ferreteria.Opciones_Admin
{
    public partial class VentanaVerListadoUsuarios : Form
    {

        public VentanaVerListadoUsuarios()
        {
            InitializeComponent();
            this.Load += VentanaVerListadoUsuarios_Load;
            this.usuarios.SelectionChanged += usuarios_SelectionChanged;
            this.comboUsuarios.SelectedIndexChanged += comboUsuarios_SelectedIndexChanged;
        }

        private void VentanaVerListadoUsuarios_Load(object sender, EventArgs e)
        {
            ConfigurarTabla();
            CargarUsuarios();

            CargarComboTiendas();
            CargarComboTipo();
            CargarComboEstado();
        }

        private void ConfigurarTabla()
        {
            usuarios.ReadOnly = true;
            usuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            usuarios.MultiSelect = false;
            usuarios.AllowUserToAddRows = false;
            usuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarComboTiendas()
        {
            DataTable dt = Conexion.VerListadoTiendas(); 
            if (dt != null)
            {
                comboTienda.DataSource = dt;
                comboTienda.DisplayMember = "denominacion"; 
                comboTienda.ValueMember = "denominacion";   
                comboTienda.SelectedIndex = -1; 
            }
        }

        private void CargarComboTipo()
        {
            comboTipo.Items.Clear();
            comboTipo.Items.Add("admin");
            comboTipo.Items.Add("user");
            comboTipo.SelectedIndex = -1;
        }

        private void CargarComboEstado()
        {
            comboEstado.Items.Clear();
            comboEstado.Items.Add("activo");
            comboEstado.Items.Add("bloqueado");
            comboEstado.SelectedIndex = -1;
        }

        private void CargarUsuarios()
        {
            DataTable dt = Conexion.VerListadoUsuarios();

            if (dt != null)
            {
                usuarios.DataSource = dt;

                comboUsuarios.DataSource = new DataTable();
                comboUsuarios.DataSource = dt;
                comboUsuarios.DisplayMember = "nombre_apellidos";
                comboUsuarios.ValueMember = "idUsuario";
                comboUsuarios.SelectedIndex = -1;
            }
        }

        private void CargarDetalle(DataRow fila)
        {
            nombreYApellidos.Text = fila["nombre_apellidos"].ToString();
            usuario.Text = fila["usuario"].ToString();
            fechaAlta.Text = Convert.ToDateTime(fila["fecha_alta"]).ToShortDateString();
            comboTienda.Text = fila["tienda"].ToString();
            comboTipo.Text = fila["tipo"].ToString();
            comboEstado.Text = fila["estado"].ToString();
        }

        private void usuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (usuarios.SelectedRows.Count > 0)
            {
                DataRow fila = ((DataRowView)usuarios.SelectedRows[0].DataBoundItem).Row;
                CargarDetalle(fila);
            }
        }

        private void comboUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboUsuarios.SelectedItem != null && comboUsuarios.Focused)
            {
                DataRow fila = ((DataRowView)comboUsuarios.SelectedItem).Row;
                CargarDetalle(fila);
            }
        }

        private void actualizar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usuario.Text))
            {
                MessageBox.Show("Por favor, seleccione un usuario de la lista.", "Aviso");
                return;
            }

            if (string.IsNullOrWhiteSpace(nombreYApellidos.Text) ||
                comboTienda.SelectedIndex == -1 ||
                comboTipo.SelectedIndex == -1 ||
                comboEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos son obligatorios para actualizar.", "Validación");
                return;
            }

            DialogResult confirmar = MessageBox.Show("¿Desea guardar los cambios para el usuario " + usuario.Text + "?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                bool exito = Conexion.ActualizarUsuario(
                    usuario.Text,
                    nombreYApellidos.Text.Trim(),
                    comboTienda.Text,
                    comboTipo.Text,
                    comboEstado.Text
                );

                if (exito)
                {
                    MessageBox.Show("Usuario actualizado correctamente.", "Éxito");
                    CargarUsuarios();
                }
            }
        }
    }
}

