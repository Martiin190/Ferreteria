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
    public partial class VentanaVerListadoCategorias : Form
    {
        public VentanaVerListadoCategorias()
        {
            InitializeComponent();
            CargarCategorias();

        }

        private void CargarCategorias()
        {
            string sql = "SELECT categoria, descripcion FROM categorias";
            dataGridView1.DataSource = Conexion.GetTabla(sql);

            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns["categoria"].HeaderText = "Categoría";
            dataGridView1.Columns["descripcion"].HeaderText = "Descripción";
        }

        private void VentanaVerListadoCategorias_Load(object sender, EventArgs e)
        {
            
        }

        

        

        private void articulos_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void registrarCategoria_Click(object sender, EventArgs e)
        {
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void actualizar_Click(object sender, EventArgs e)
        {

            // Validar campos
            if (CampoCategoria.Text.Trim() == "" || CampoDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Conexion.conectar();
                string sql = "INSERT INTO categorias (categoria, descripcion) " +
                             "VALUES (@cat, @desc)";
                MySqlCommand cmd = new MySqlCommand(sql, Conexion.conn);
                cmd.Parameters.AddWithValue("@cat", CampoCategoria.Text.Trim());
                cmd.Parameters.AddWithValue("@desc", CampoDescripcion.Text.Trim());
                cmd.ExecuteNonQuery();
                Conexion.cerrar();

                MessageBox.Show("Categoría registrada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar campos y recargar tabla
                CampoCategoria.Text = "";
                CampoDescripcion.Text = "";
                CargarCategorias();
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

