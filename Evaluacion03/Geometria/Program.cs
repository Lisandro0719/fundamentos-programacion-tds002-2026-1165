
/*
Nombre: Lisandro
Fecha: 03/11/2026
Descripcion: Programa que calcula el area y la
circunferencia de un circulo, y la hipotenusa
de un triangulo rectangulo.
*/

using System;
using System.Globalization;

namespace Geometria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarar la constante para el diametro.
            const double FACTOR_DIAMETRO = 2.0;

            // Solicitar el radio del circulo.
            Console.Write("Introduce el radio del circulo: ");
            double radio = double.Parse(
                (Console.ReadLine() ?? "0").Replace(',', '.'),
                CultureInfo.InvariantCulture
            );

            // Solicitar los catetos del triangulo.
            Console.Write("Introduce el primer cateto: ");
            double catetoUno = double.Parse(
                (Console.ReadLine() ?? "0").Replace(',', '.'),
                CultureInfo.InvariantCulture
            );

            Console.Write("Introduce el segundo cateto: ");
            double catetoDos = double.Parse(
                (Console.ReadLine() ?? "0").Replace(',', '.'),
                CultureInfo.InvariantCulture
            );

            // Calcular el area del circulo.
            double areaCirculo = Math.PI * Math.Pow(radio, 2);

            // Calcular la circunferencia del circulo.
            double circunferencia =
                FACTOR_DIAMETRO * Math.PI * radio;

            // Calcular la hipotenusa con Pitagoras.
            double hipotenusa = Math.Sqrt(
                Math.Pow(catetoUno, 2) + Math.Pow(catetoDos, 2)
            );

            // Mostrar los resultados.
            Console.WriteLine("\n===== RESULTADOS DE GEOMETRIA =====");
            Console.WriteLine($"Radio del circulo: {radio:F2}");
            Console.WriteLine($"Area del circulo: {areaCirculo:F2}");
            Console.WriteLine($"Circunferencia: {circunferencia:F2}");
            Console.WriteLine($"Primer cateto: {catetoUno:F2}");
            Console.WriteLine($"Segundo cateto: {catetoDos:F2}");
            Console.WriteLine($"Hipotenusa: {hipotenusa:F2}");
            Console.WriteLine("==================================");
        }
    }
}