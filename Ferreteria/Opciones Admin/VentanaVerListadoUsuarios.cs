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
        }

        private void ConfigurarTabla()
        {
            usuarios.ReadOnly = true;
            usuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            usuarios.MultiSelect = false;
            usuarios.AllowUserToAddRows = false;
            usuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            nombreYApellidos.Clear();
            usuario.Clear();
            fechaAlta.Clear();
            comboTienda.SelectedIndex = -1;
            comboTipo.SelectedIndex = -1;
            comboEstado.SelectedIndex = -1;
            usuarios.ClearSelection();
            comboUsuarios.SelectedIndex = -1;
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            // Aquí irá la lógica de actualizar cuando la tengas
        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

