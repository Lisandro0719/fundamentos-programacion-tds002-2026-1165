/*
Nombre: Lisandro
Descripcion: Programa que demuestra conversiones
explicitas e implicitas entre tipos numericos.
*/

using System;
using System.Globalization;

namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar un numero decimal.
            Console.Write("Introduce un numero con decimales: ");
            double numeroDecimal = double.Parse(
                (Console.ReadLine() ?? "0").Replace(',', '.'),
                CultureInfo.InvariantCulture
            );

            // Casting explicito de double a int.
            int numeroEntero = (int)numeroDecimal;

            // Conversion implicita de int a double.
            double numeroConvertido = numeroEntero;

            // Mostrar los resultados con interpolacion.
            Console.WriteLine("\n===== EJEMPLO DE CASTING =====");
            Console.WriteLine($"Numero original: {numeroDecimal}");
            Console.WriteLine($"Casting explicito (double a int): {numeroEntero}");
            Console.WriteLine($"Conversion implicita (int a double): {numeroConvertido:F1}");
            Console.WriteLine("==============================");
        }
    }
}