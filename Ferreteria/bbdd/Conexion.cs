using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Ferreteria.bbdd
{
    internal class Conexion

        {
            public static MySqlConnection conn;

            private static readonly string url =
                "Server=145.14.151.51; " +
                "Database=u812167471_mascotas; " +
                "User=u812167471_mascotas; " +
                "port=3306; " +
                "password=2026-Mascotas";

            public static void conectar()
            {
                try
                {
                    conn = new MySqlConnection(url);
                    conn.Open();
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Error al conectar con la base de datos.\n" + e.Message);
                }

            }

            public static void cerrar()
            {
                if (conn != null)
                {
                    try
                    {
                        conn.Close();
                    }
                    catch (MySqlException e)
                    {
                        MessageBox.Show("Error al cerrar la conexión con la base de datos.\n" + e.Message);
                    }
                }

            }

            public static bool acceder(string user, string pass)
            {
                string consulta = "SELECT usuario FROM usuarios " +
                    "WHERE usuario = ?user AND pass = ?pass";

                conectar();

                try
                {
                    MySqlCommand comando = new MySqlCommand(consulta, conn);

                    comando.Parameters.AddWithValue("?user", user);
                    comando.Parameters.AddWithValue("?pass", pass);

                    MySqlDataReader lector = comando.ExecuteReader();

                    if (lector.Read())
                    {
                        return true;
                    }
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Error en la consulta a base de datos.\n" + e.Message);
                }
                finally
                {
                    cerrar();
                }

                return false;
            }

        }
}
