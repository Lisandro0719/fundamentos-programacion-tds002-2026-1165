
/*
Nombre: Lisandro
Descripcion: Programa de caja registradora que
suma precios, calcula ITBIS y muestra el total.
*/

using System;
using System.Globalization;

namespace CajaRegistradora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarar constante y variables.
            const decimal TASA_ITBIS = 0.18m;

            decimal precio = 0;
            decimal subtotal = 0;
            int cantidadProductos = 0;

            Console.WriteLine("===== CAJA REGISTRADORA =====");
            Console.WriteLine("Escribe 0 para finalizar.\n");

            // Solicitar precios utilizando do-while.
            do
            {
                Console.Write("Introduce el precio del producto: RD$ ");
                string? entrada = Console.ReadLine();

                if (entrada == null)
                {
                    Console.WriteLine("Entrada finalizada.");
                    return;
                }

                // Validar que el precio sea numerico.
                bool esValido = decimal.TryParse(
                    entrada.Replace(',', '.'),
                    NumberStyles.Number,
                    CultureInfo.InvariantCulture,
                    out precio
                );

                if (!esValido || precio < 0)
                {
                    Console.WriteLine("Error: introduce un precio valido.");
                    continue;
                }

                // Agregar solamente precios mayores que cero.
                if (precio > 0)
                {
                    subtotal += precio;
                    cantidadProductos++;

                    Console.WriteLine("Producto agregado correctamente.\n");
                }

            } while (precio != 0);

            // Calcular el ITBIS y el total.
            decimal itbis = subtotal * TASA_ITBIS;
            decimal total = subtotal + itbis;

            // Mostrar los resultados con dos decimales.
            Console.WriteLine("\n===== RESUMEN DE COMPRA =====");
            Console.WriteLine($"Cantidad de productos: {cantidadProductos}");
            Console.WriteLine($"Subtotal: RD$ {subtotal:N2}");
            Console.WriteLine($"ITBIS (18%): RD$ {itbis:N2}");
            Console.WriteLine($"Total a pagar: RD$ {total:N2}");
            Console.WriteLine("============================");
        }
    }
}