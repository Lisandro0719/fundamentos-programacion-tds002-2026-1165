/*
Nombre: Lisandro
Descripcion: Programa que solicita datos personales
y calcula el año aproximado en que cumplira 30 años.
*/

using System;
using System.Globalization;

namespace FichaPersonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarar el año actual.
            const int anioActual = 2026;

            // Solicitar el nombre.
            Console.Write("Introduce tu nombre: ");
            string nombre = Console.ReadLine() ?? "";

            // Solicitar la edad.
            Console.Write("Introduce tu edad: ");
            int edad = int.Parse(Console.ReadLine() ?? "0");

            // Solicitar la estatura.
            Console.Write("Introduce tu estatura en metros: ");
            double estatura = double.Parse(
                (Console.ReadLine() ?? "0").Replace(',', '.'),
                CultureInfo.InvariantCulture
            );

            // Solicitar si la persona trabaja.
            Console.Write("¿Trabajas? (true/false): ");
            bool trabaja = bool.Parse(Console.ReadLine() ?? "false");

            // Calcular el año aproximado en que cumple 30.
            int anioTreinta = anioActual + (30 - edad);

            // Mostrar la ficha con interpolacion.
            Console.WriteLine("\n===== FICHA PERSONAL =====");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad} años");
            Console.WriteLine($"Estatura: {estatura:F2} metros");
            Console.WriteLine($"Trabaja: {trabaja}");
            Console.WriteLine($"Cumple 30 años aproximadamente en: {anioTreinta}");
            Console.WriteLine("==========================");
        }
    }
}
