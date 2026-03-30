using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.Utilidades
{
    internal class Utilidades
    {
            public static bool CampoVacio(TextBox campo)
            {
                return campo.Text == string.Empty;
            }

            public static void LanzaAlertaVacio(TextBox campo)
            {
                MessageBox.Show("El campo " + campo.Tag + " es obligatorio");
            }

            public static bool ComboVacio(ComboBox combo)
            {
                return combo.SelectedIndex == 0;
            }

            public static void LanzaComboVacio(ComboBox combo)
            {
                MessageBox.Show("Debe seleccionar un elemento en el desplegable "
                    + combo.Tag);
            }

            public static bool EnteroNoCorrecto(TextBox campo)
            {
                int numero;

                return !int.TryParse(campo.Text, out numero);
            }

            public static void LanzaEnteroIncorrecto(TextBox campo)
            {
                MessageBox.Show("El campo " + campo.Tag + " debe ser un numero entero");
            }


            public static string CompruebaStringValido(string mensajePeticion)
            {
                Console.WriteLine(mensajePeticion);
                string cadenaTecleada;

                do
                {
                    cadenaTecleada = Console.ReadLine()?.Trim() ?? "";

                    if (string.IsNullOrEmpty(cadenaTecleada))
                    {
                        Console.WriteLine("Este campo es obligatorio");
                        Console.WriteLine(mensajePeticion);
                    }

                } while (string.IsNullOrEmpty(cadenaTecleada));

                return cadenaTecleada;
            }

            /// <summary>
            /// Solicita y valida un número entero
            /// </summary>
            /// <param name="peticion">Mensaje que se muestra al usuario</param>
            /// <returns>Número entero válido</returns>
            public static int EnteroValido(string peticion)
            {
                Console.WriteLine(peticion);
                int cantidad = 0;
                bool numeroOk = false;

                do
                {
                    string cantidadTecleada = Console.ReadLine();

                    if (int.TryParse(cantidadTecleada, out cantidad))
                    {
                        numeroOk = true;
                    }
                    else
                    {
                        Console.WriteLine("Número no válido");
                        Console.WriteLine(peticion);
                    }

                } while (!numeroOk);

                return cantidad;
            }

            /// <summary>
            /// Solicita y valida un número double
            /// </summary>
            /// <param name="peticion">Mensaje que se muestra al usuario</param>
            /// <returns>Número double válido</returns>
            public static double DoubleValido(string peticion)
            {
                Console.WriteLine(peticion);
                double cantidad = 0;
                bool numeroOk = false;

                do
                {
                    string cantidadTecleada = Console.ReadLine();

                    if (double.TryParse(cantidadTecleada, out cantidad))
                    {
                        numeroOk = true;
                    }
                    else
                    {
                        Console.WriteLine("Número no válido");
                        Console.WriteLine(peticion);
                    }

                } while (!numeroOk);

                return cantidad;
            }

            /// <summary>
            /// Solicita y valida un número entero dentro de un rango específico
            /// </summary>
            /// <param name="peticion">Mensaje que se muestra al usuario</param>
            /// <param name="min">Valor mínimo permitido</param>
            /// <param name="max">Valor máximo permitido</param>
            /// <returns>Número entero válido dentro del rango</returns>
            public static int EnteroValidoEnRango(string peticion, int min, int max)
            {
                int cantidad;
                bool numeroOk = false;

                do
                {
                    cantidad = EnteroValido(peticion);

                    if (cantidad >= min && cantidad <= max)
                    {
                        numeroOk = true;
                    }
                    else
                    {
                        Console.WriteLine($"El número debe estar entre {min} y {max}");
                    }

                } while (!numeroOk);

                return cantidad;
            }

            /// <summary>
            /// Solicita y valida un número double dentro de un rango específico
            /// </summary>
            /// <param name="peticion">Mensaje que se muestra al usuario</param>
            /// <param name="min">Valor mínimo permitido</param>
            /// <param name="max">Valor máximo permitido</param>
            /// <returns>Número double válido dentro del rango</returns>
            public static double DoubleValidoEnRango(string peticion, double min, double max)
            {
                double cantidad;
                bool numeroOk = false;

                do
                {
                    cantidad = DoubleValido(peticion);

                    if (cantidad >= min && cantidad <= max)
                    {
                        numeroOk = true;
                    }
                    else
                    {
                        Console.WriteLine($"El número debe estar entre {min} y {max}");
                    }

                } while (!numeroOk);

                return cantidad;
            }
        }
    }

