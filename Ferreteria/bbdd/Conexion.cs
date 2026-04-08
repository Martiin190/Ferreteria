using Ferreteria.Modelos;
using MySqlConnector;
using Mysqlx;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.bbdd
{
    public class Conexion
    {
        public static MySqlConnection conn;

        private static readonly string url =
            "Server=127.0.0.1; " +
            "Database=ferreteria; " +
            "User=root; " +
            "port=3307; " +
            "password=";

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





        // Devuelve el tipo ("admin"/"user") si login correcto, null si falla
        public static string Login(string usuario, string pass)
        {
            conectar();
            try
            {
                string sql = "SELECT tipo FROM usuarios WHERE usuario=@u AND pass=@p AND estado='activo'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", usuario);
                cmd.Parameters.AddWithValue("@p", pass);
                object resultado = cmd.ExecuteScalar();
                return resultado != null ? resultado.ToString() : null;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error en el login.\n" + e.Message);
                return null;
            }
            finally
            {
                cerrar();
            }
        }

        // Registra el acceso en la tabla accesos
        public static void RegistrarAcceso(string usuario)
        {
            conectar();
            try
            {
                string sql = "INSERT INTO accesos (usuario, fecha, ip) VALUES (@u, @f, @ip)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", usuario);
                cmd.Parameters.AddWithValue("@f", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@ip", ObtenerIP());
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error al registrar acceso.\n" + e.Message);
            }
            finally
            {
                cerrar();
            }
        }

        private static string ObtenerIP()
        {
            try
            {
                foreach (var ip in System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName()))
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        return ip.ToString();
            }
            catch { }
            return "127.0.0.1";
        }


        public static MySqlDataReader GetDatosCuenta(string usuario)
        {
            conectar();
            string sql = "SELECT nombre_apellidos, usuario, pass, tipo, estado, fecha_alta " +
                         "FROM usuarios WHERE usuario = @u";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@u", usuario);
            // CommandBehavior.CloseConnection cierra la conn al cerrar el reader
            return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }

        // Actualiza nombre y opcionalmente la contraseña
        public static bool ActualizarCuenta(string usuario, string nombre, string nuevaPass)
        {
            conectar();
            try
            {
                string sql;

                if (nuevaPass != null)
                    sql = "UPDATE usuarios SET nombre_apellidos = @nombre, pass = @pass " +
                          "WHERE usuario = @u";
                else
                    sql = "UPDATE usuarios SET nombre_apellidos = @nombre " +
                          "WHERE usuario = @u";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@u", usuario);

                if (nuevaPass != null)
                    cmd.Parameters.AddWithValue("@pass", nuevaPass);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error al actualizar la cuenta.\n" + e.Message);
                return false;
            }
            finally
            {
                cerrar();
            }
        }

        // Verifica que la contraseña actual introducida es correcta
        public static bool VerificarPass(string usuario, string pass)
        {
            conectar();
            try
            {
                string sql = "SELECT COUNT(*) FROM usuarios WHERE usuario = @u AND pass = @p";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", usuario);
                cmd.Parameters.AddWithValue("@p", pass);
                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                return resultado > 0;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error al verificar la contraseña.\n" + e.Message);
                return false;
            }
            finally
            {
                cerrar();
            }
        }


        public static DataTable GetTabla(string sql)
        {
            conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error al cargar datos.\n" + e.Message);
                return null;
            }
            finally
            {
                cerrar();
            }
        }

        //Devuelve un DataTable de la base de datos, con el producto que tenga el código introducido
        public static DataTable VerListadoArticulos(string codigo)
        {
            conectar();
            try
            {
                string sql = "SELECT * FROM producto WHERE codProducto = @cod";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cod", codigo);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error al cargar los articulos.\n" + e.Message);
                return null;
            }
            finally { cerrar(); }
        }

        public static bool ActualizarArticulos(string codigo, string nombre, string descripcion)
        {
            conectar();
            try
            {
                // Solo actualizamos los dos campos permitidos
                string sql = "UPDATE producto SET nombre = @nom, descripcion = @desc WHERE codProducto = @cod";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nom", nombre);
                cmd.Parameters.AddWithValue("@desc", descripcion);
                cmd.Parameters.AddWithValue("@cod", codigo);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
                return false;
            }
            finally { cerrar(); }
        }

        public static bool EliminarProducto(string codigo)
        {
            conectar();
            try
            {
                string sql = "DELETE FROM producto WHERE codProducto = @cod";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cod", codigo);
                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al eliminar: " + e.Message);
                return false;
            }
            finally { cerrar(); }
        }

        public static DataTable VerListadoArticulosDestacados()
        {
            conectar();
            try
            {
                string sql = "SELECT codProducto, nombre, categoria, descripcion, " +
                             "precio_compra, precio_venta, stock, origen, oferta, fecha_alta " +
                             "FROM producto WHERE destacado = 'SI' ORDER BY nombre ASC";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error al cargar los articulos destacados.\n" + e.Message);
                return null;
            }
            finally
            {
                cerrar();
            }
        }

        public static DataTable VerListadoArticulosEnOferta()
        {
            conectar();
            try
            {
                string sql = "SELECT codProducto, nombre, categoria, descripcion, " +
                             "precio_compra, precio_venta, stock, origen, destacado, oferta, fecha_alta " +
                             "FROM producto WHERE oferta = 'SI' ORDER BY nombre ASC";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error al cargar los articulos en oferta.\n" + e.Message);
                return null;
            }
            finally
            {
                cerrar();
            }
        }

        public static bool ActualizarOferta(string codigo, string nuevoEstado)
        {
            conectar();
            try
            {
                string sql = "UPDATE producto SET oferta = @estado WHERE codProducto = @cod";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@estado", nuevoEstado);
                cmd.Parameters.AddWithValue("@cod", codigo);
                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error al actualizar el estado de oferta.\n" + e.Message);
                return false;
            }
            finally
            {
                cerrar();
            }
        }

        public static DataTable VerListadoCategorias()
        {
            conectar();
            try
            {
                string sql = "SELECT categoria AS Denominacion, descripcion AS Descripcion FROM categorias";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error al cargar categorías.\n" + e.Message);
                return null;
            }
            finally
            {
                cerrar();
            }
        }

        // Registra una nueva categoría
        public static bool RegistrarCategoria(string denominacion, string descripcion)
        {
            conectar();
            try
            {
                string sql = "INSERT INTO categorias (categoria, descripcion) VALUES (@cat, @desc)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cat", denominacion);
                cmd.Parameters.AddWithValue("@desc", descripcion);
                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error al registrar la categoría.\n" + e.Message);
                return false;
            }
            finally
            {
                cerrar();
            }
        }

        public static DataTable VerListadoOrigenes()
        {
            conectar();
            try
            {
                string sql = "SELECT origen AS Denominacion, descripcion AS Descripcion FROM origen";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error al cargar orígenes.\n" + e.Message);
                return null;
            }
            finally
            {
                cerrar();
            }
        }

        // Registra un nuevo origen
        public static bool RegistrarOrigen(string denominacion, string descripcion)
        {
            conectar();
            try
            {
                string sql = "INSERT INTO origen (origen, descripcion) VALUES (@origen, @desc)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@origen", denominacion);
                cmd.Parameters.AddWithValue("@desc", descripcion);
                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error al registrar el origen.\n" + e.Message);
                return false;
            }
            finally
            {
                cerrar();
            }
        }

        public static DataTable VerListadoTiendas()
        {
            conectar();
            try
            {
                string sql = "SELECT denominacion, direccion, responsable FROM tiendas";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error al cargar tiendas.\n" + e.Message);
                return null;
            }
            finally
            {
                cerrar();
            }
        }

        // Devuelve todos los responsables
        public static DataTable GetResponsables()
        {
            conectar();
            try
            {
                string sql = "SELECT nombre_apellidos FROM responsables_tienda ORDER BY nombre_apellidos ASC";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error al cargar responsables.\n" + e.Message);
                return null;
            }
            finally
            {
                cerrar();
            }
        }

        // Registra una nueva tienda
        public static bool RegistrarTienda(string denominacion, string direccion, string responsable)
        {
            conectar();
            try
            {
                string sql = "INSERT INTO tiendas (denominacion, direccion, responsable) " +
                             "VALUES (@den, @dir, @resp)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@den", denominacion);
                cmd.Parameters.AddWithValue("@dir", direccion);
                cmd.Parameters.AddWithValue("@resp", responsable);
                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error al registrar la tienda.\n" + e.Message);
                return false;
            }
            finally
            {
                cerrar();
            }
        }

        public static DataTable VerListadoUsuarios()
        {
            conectar();
            try
            {
                string sql = "SELECT idUsuario, nombre_apellidos, tienda, usuario, tipo, estado, fecha_alta " +
                             "FROM usuarios ORDER BY nombre_apellidos ASC";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error al cargar usuarios.\n" + e.Message);
                return null;
            }
            finally
            {
                cerrar();
            }
        }

        public static bool ActualizarUsuario(string login, string nombre, string tienda, string tipo, string estado)
        {
            conectar();
            try
            {
                string sql = @"UPDATE usuarios 
                       SET nombre_apellidos = @nom, tienda = @tienda, tipo = @tipo, estado = @est 
                       WHERE usuario = @user";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nom", nombre);
                cmd.Parameters.AddWithValue("@tienda", tienda);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@est", estado);
                cmd.Parameters.AddWithValue("@user", login);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al actualizar usuario: " + e.Message);
                return false;
            }
            finally { cerrar(); }
        }

        public static bool RegistrarArticulo(string cod, string nom, string cat, string desc, double pc, double pv, int st, string ori, string dest, string ofer, DateTime fecha)
        {
            conectar();
            try
            {
                string sql = "INSERT INTO producto VALUES (@cod, @nom, @cat, @desc, @pc, @pv, @st, @ori, @dest, @ofer, @fecha)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cod", cod);
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@cat", cat);
                cmd.Parameters.AddWithValue("@desc", desc);
                cmd.Parameters.AddWithValue("@pc", pc);
                cmd.Parameters.AddWithValue("@pv", pv);
                cmd.Parameters.AddWithValue("@st", st);
                cmd.Parameters.AddWithValue("@ori", ori);
                cmd.Parameters.AddWithValue("@dest", dest);
                cmd.Parameters.AddWithValue("@ofer", ofer);
                cmd.Parameters.AddWithValue("@fecha", fecha);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de DB: " + ex.Message);
                return false;
            }
            finally { cerrar(); }
        }

        public static bool ExisteUsuario(string usuario)
        {
            conectar();
            try
            {
                string sql = "SELECT COUNT(*) FROM usuarios WHERE usuario = @u";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", usuario);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
            catch { return false; }
            finally { cerrar(); }
        }

        public static bool RegistrarUsuario(string nombre, string tienda, string usuario,
        string pass, string tipo, string estado, DateTime fecha)
        {
            conectar();
            try
            {
                string sql = "INSERT INTO usuarios (nombre_apellidos, tienda, usuario, pass, tipo, estado, fecha_alta) " +
                             "VALUES (@nom, @tienda, @user, @pass, @tipo, @est, @fecha)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nom", nombre);
                cmd.Parameters.AddWithValue("@tienda", tienda);
                cmd.Parameters.AddWithValue("@user", usuario);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@est", estado);
                cmd.Parameters.AddWithValue("@fecha", fecha);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al registrar en DB: " + e.Message);
                return false;
            }
            finally { cerrar(); }
        }

        public static DataTable ObtenerDatosUsuario(string usuario)
        {
            conectar();
            try
            {
                string sql = "SELECT nombre_apellidos, usuario, tipo, estado FROM usuarios WHERE usuario = @u";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", usuario);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch { return null; }
            finally { cerrar(); }
        }

        public static bool ActualizarPerfil(string usuario, string nombre, string nuevaPass)
        {
            conectar();
            try
            {
                string sql;
                // Limpiamos espacios en blanco del usuario por si acaso
                string usuarioLimpio = usuario.Trim();

                if (string.IsNullOrEmpty(nuevaPass))
                    sql = "UPDATE usuarios SET nombre_apellidos = @nom WHERE TRIM(usuario) = @u";
                else
                    sql = "UPDATE usuarios SET nombre_apellidos = @nom, pass = @pass WHERE TRIM(usuario) = @u";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nom", nombre.Trim());
                cmd.Parameters.AddWithValue("@u", usuarioLimpio);

                if (!string.IsNullOrEmpty(nuevaPass))
                    cmd.Parameters.AddWithValue("@pass", nuevaPass.Trim());

                int filas = cmd.ExecuteNonQuery();

                if (filas == 0)
                {
                    // Este mensaje te dirá exactamente qué nombre está buscando la App
                    MessageBox.Show("Base de datos conectada, pero no existe el usuario: '" + usuarioLimpio + "'");
                }

                return filas > 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error técnico: " + e.Message);
                return false;
            }
            finally { cerrar(); }
        }


        //===========================================================================================//
                  //METODOS PARA QUE FUNCIONEN LOS CAMBIOS EN LOS COMBOBOXES DE LOS LISTADOS

        public static void CambiarDestacado(string codigo, string valor)
        {
            conectar();
            try
            {
                string sql = "UPDATE producto SET destacado = @v WHERE codProducto = @c";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@v", valor);
                cmd.Parameters.AddWithValue("@c", codigo);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error al actualizar destacado.\n" + e.Message);
            }
            finally
            {
                cerrar();
            }
        }



        public static void CambiarOferta(string codigo, string valor)
        {
            conectar();
            try
            {
                string sql = "UPDATE producto SET oferta = @v WHERE codProducto = @c";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@v", valor);
                cmd.Parameters.AddWithValue("@c", codigo);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error al actualizar oferta.\n" + e.Message);
            }
            finally
            {
                cerrar();
            }
        }






    }


}

