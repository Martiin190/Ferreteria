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
    public partial class VentanaVerListadoOrigenes : Form
    {
        public VentanaVerListadoOrigenes()
        {
            InitializeComponent();
            CargarOrigenes();

        }

        private void CargarOrigenes()
        {
            string sql = "SELECT origen, descripcion FROM origen";
            dataGridView1.DataSource = Conexion.GetTabla(sql);

            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns["origen"].HeaderText = "Origen";
            dataGridView1.Columns["descripcion"].HeaderText = "Descripción";
        }

        private void VentanaVerListadoOrigenes_Load(object sender, EventArgs e)
        {
            
        }

       
        private void articulos_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            if (CampoOrigen.Text.Trim() == "" || CampoDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Conexion.conectar();
                string sql = "INSERT INTO origen (origen, descripcion) " +
                             "VALUES (@ori, @desc)";
                MySqlCommand cmd = new MySqlCommand(sql, Conexion.conn);
                cmd.Parameters.AddWithValue("@ori", CampoOrigen.Text.Trim());
                cmd.Parameters.AddWithValue("@desc", CampoDescripcion.Text.Trim());
                cmd.ExecuteNonQuery();
                Conexion.cerrar();

                MessageBox.Show("Origen registrado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CampoOrigen.Text = "";
                CampoDescripcion.Text = "";
                CargarOrigenes();
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

        private void CampoOrigen_TextChanged(object sender, EventArgs e)
        {

        }

        private void CampoDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
