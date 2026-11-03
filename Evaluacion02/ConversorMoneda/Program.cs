/*
Nombre: Lisandro
Descripcion: Programa que convierte pesos dominicanos
a dolares estadounidenses usando una tasa fija.
*/

using System;
using System.Globalization;

namespace ConversorMoneda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tasa de venta USD/DOP del 02/11/2026.
            const double TASA_USD = 60.5689;

            // Solicitar el monto en pesos dominicanos.
            Console.Write("Introduce el monto en pesos dominicanos: RD$ ");
            double montoPesos = double.Parse(
                (Console.ReadLine() ?? "0").Replace(',', '.'),
                CultureInfo.InvariantCulture
            );

            // Convertir pesos a dolares.
            double montoDolares = montoPesos / TASA_USD;

            // Mostrar el resultado con interpolacion.
            Console.WriteLine("\n===== CONVERSOR DE MONEDA =====");
            Console.WriteLine($"Monto en pesos: RD$ {montoPesos:F2}");
            Console.WriteLine($"Tasa USD: RD$ {TASA_USD:F4}");
            Console.WriteLine($"Equivalente en dolares: US$ {montoDolares:F2}");
            Console.WriteLine("===============================");
        }
    }
}