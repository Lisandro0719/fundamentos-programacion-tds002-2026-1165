/*
Nombre: Lisandro
Fecha: 03/11/2026
Descripcion: Programa que calcula el subtotal,
el ITBIS y el total de una factura.
*/

using System;
using System.Globalization;

namespace Factura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarar la constante del ITBIS.
            const decimal TASA_ITBIS = 0.18m;

            // Solicitar el nombre del producto.
            Console.Write("Introduce el nombre del producto: ");
            string producto = Console.ReadLine() ?? "";

            // Solicitar la cantidad.
            Console.Write("Introduce la cantidad: ");
            int cantidad = int.Parse(Console.ReadLine() ?? "0");

            // Solicitar el precio unitario.
            Console.Write("Introduce el precio unitario: RD$ ");
            decimal precioUnitario = decimal.Parse(
                (Console.ReadLine() ?? "0").Replace(',', '.'),
                CultureInfo.InvariantCulture
            );

            // Calcular el subtotal.
            decimal subtotal = cantidad * precioUnitario;

            // Calcular el ITBIS.
            decimal itbis = subtotal * TASA_ITBIS;

            // Calcular el total.
            decimal total = subtotal + itbis;

            // Mostrar la factura en columnas alineadas.
            Console.WriteLine("\n================ FACTURA ================");
            Console.WriteLine(
                $"{"Producto".PadRight(18)} {"Cantidad",8} {"Precio",12}"
            );

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine(
                $"{producto.PadRight(18)} {cantidad,8} {precioUnitario,12:N2}"
            );

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"{"Subtotal".PadRight(28)} {subtotal,12:N2}");
            Console.WriteLine($"{"ITBIS (18%)".PadRight(28)} {itbis,12:N2}");
            Console.WriteLine($"{"TOTAL".PadRight(28)} {total,12:N2}");
            Console.WriteLine("=========================================");
        }
    }
}
