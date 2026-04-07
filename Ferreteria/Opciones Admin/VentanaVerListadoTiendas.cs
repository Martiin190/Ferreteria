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
using MySqlConnector;

namespace Ferreteria.Opciones_Admin
{
    public partial class VentanaVerListadoTiendas : Form
    {
        public VentanaVerListadoTiendas()
        {
            InitializeComponent();
            CargarTiendas();
            CargarResponsables();
        }
        private void CargarTiendas()
        {
            string sql = "SELECT denominacion, direccion, responsable FROM tiendas";
            dataGridView1.DataSource = Conexion.GetTabla(sql);

            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns["denominacion"].HeaderText = "Denominación";
            dataGridView1.Columns["direccion"].HeaderText = "Dirección";
            dataGridView1.Columns["responsable"].HeaderText = "Responsable";
        }
        private void CargarResponsables()
        {
            string sql = "SELECT nombre_apellidos FROM responsables_tienda";
            DataTable dt = Conexion.GetTabla(sql);

            ComboResponsable.DataSource = dt;
            ComboResponsable.DisplayMember = "nombre_apellidos";
            ComboResponsable.ValueMember = "nombre_apellidos";
            ComboResponsable.SelectedIndex = -1;
        }

        private void VentanaVerListadoTiendas_Load(object sender, EventArgs e)
        {
            
        }

        private void ConfiguracionInterfaz()
        {
            
        }

        private void CargarListadoTiendas()
        {
        }

        private void CargarResponsablesEnCombo()
        {
           
        }

        private void tiendas_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void registrarTienda_Click(object sender, EventArgs e)
        {
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
        }

       

        private void actualizar_Click(object sender, EventArgs e)
        { if (CampoDenominacion.Text.Trim() == "" ||
                CampoDireccion.Text.Trim() == "" ||
                ComboResponsable.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Conexion.conectar();
                string sql = "INSERT INTO tiendas (denominacion, direccion, responsable) " +
                             "VALUES (@den, @dir, @res)";
    MySqlCommand cmd = new MySqlCommand(sql, Conexion.conn);
    cmd.Parameters.AddWithValue("@den", CampoDenominacion.Text.Trim());
                cmd.Parameters.AddWithValue("@dir", CampoDireccion.Text.Trim());
                cmd.Parameters.AddWithValue("@res", ComboResponsable.SelectedValue.ToString());
                cmd.ExecuteNonQuery();
                Conexion.cerrar();

                MessageBox.Show("Tienda registrada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CampoDenominacion.Text = "";
                CampoDireccion.Text = "";
                ComboResponsable.SelectedIndex = -1;
                CargarTiendas();
}
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
    }

