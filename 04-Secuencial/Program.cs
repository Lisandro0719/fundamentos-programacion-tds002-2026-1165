/*
Nombre: Lisandro
Fecha: 03/11/2026
Descripcion: Programa secuencial que convierte
un peso de libras a kilogramos y una temperatura
de Fahrenheit a Celsius.
*/

using System;
using System.Globalization;

namespace _04_Secuencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constante para convertir libras a kilogramos.
            const double LIBRA_A_KG = 0.453592;

            // Solicitar el peso en libras.
            Console.Write("Introduce tu peso en libras: ");
            double pesoLibras = double.Parse(
                (Console.ReadLine() ?? "0").Replace(',', '.'),
                CultureInfo.InvariantCulture
            );

            // Solicitar la temperatura en Fahrenheit.
            Console.Write("Introduce la temperatura en grados Fahrenheit: ");
            double temperaturaFahrenheit = double.Parse(
                (Console.ReadLine() ?? "0").Replace(',', '.'),
                CultureInfo.InvariantCulture
            );

            // Convertir libras a kilogramos.
            double pesoKilogramos = pesoLibras * LIBRA_A_KG;

            // Convertir Fahrenheit a Celsius.
            double temperaturaCelsius =
                (temperaturaFahrenheit - 32) * 5 / 9;

            // Mostrar los resultados con dos decimales.
            Console.WriteLine("\n===== CONVERSOR DE UNIDADES =====");
            Console.WriteLine($"Peso original: {pesoLibras:F2} lb");
            Console.WriteLine($"Peso convertido: {pesoKilogramos:F2} kg");
            Console.WriteLine($"Temperatura original: {temperaturaFahrenheit:F2} °F");
            Console.WriteLine($"Temperatura convertida: {temperaturaCelsius:F2} °C");
            Console.WriteLine("================================");
        }
    }
}