
/*
Nombre: Lisandro Muñoz
Fecha: 02/11/2026
Descripcion: Programa que solicita datos personales,
calcula el año de nacimiento y muestra los resultados.
*/

using System;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarar la constante del año actual.
            const int ANIO_ACTUAL = 2026;

            // Solicitar el nombre del usuario.
            Console.Write("Introduce tu nombre: ");
            string nombre = Console.ReadLine() ?? "";

            // Solicitar la edad del usuario.
            Console.Write("Introduce tu edad: ");
            int edad = int.Parse(Console.ReadLine() ?? "0");

            // Solicitar la estatura en metros.
            Console.Write("Introduce tu estatura en metros (ejemplo 1.65): ");
            double estatura = double.Parse(
                (Console.ReadLine() ?? "0").Replace(',', '.'),
                System.Globalization.CultureInfo.InvariantCulture
            );

            // Calcular el año de nacimiento aproximado.
            int anioNacimiento = ANIO_ACTUAL - edad;

            // Mostrar los datos mediante interpolacion.
            Console.WriteLine("\n===== DATOS PERSONALES =====");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad} años");
            Console.WriteLine($"Estatura: {estatura:F2} metros");
            Console.WriteLine($"Año de nacimiento aproximado: {anioNacimiento}");
            Console.WriteLine($"Año actual: {ANIO_ACTUAL}");
            Console.WriteLine("============================");
        }
    }
}
