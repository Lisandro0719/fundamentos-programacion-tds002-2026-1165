
/*
Nombre: Lisandro
Fecha: 03/11/2026
Descripcion: Programa que solicita dos numeros enteros
y realiza operaciones aritmeticas y logicas.
*/

using System;

namespace _03_Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar los dos numeros enteros.
            Console.Write("Introduce el primer numero: ");
            int primerNumero = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Introduce el segundo numero: ");
            int segundoNumero = int.Parse(Console.ReadLine() ?? "0");

            // Realizar las operaciones aritmeticas.
            int suma = primerNumero + segundoNumero;
            int resta = primerNumero - segundoNumero;
            int producto = primerNumero * segundoNumero;

            // Comprobar si el primer numero es par.
            bool esPar = primerNumero % 2 == 0;

            // Mostrar los resultados con interpolacion.
            Console.WriteLine("\n===== OPERACIONES =====");
            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Resta: {resta}");
            Console.WriteLine($"Producto: {producto}");

            // Evitar la division entre cero.
            if (segundoNumero != 0)
            {
                double divisionReal =
                    (double)primerNumero / segundoNumero;

                int divisionEntera =
                    primerNumero / segundoNumero;

                int residuo =
                    primerNumero % segundoNumero;

                Console.WriteLine($"Division real: {divisionReal:F2}");
                Console.WriteLine($"Division entera: {divisionEntera}");
                Console.WriteLine($"Residuo: {residuo}");
            }
            else
            {
                Console.WriteLine("No se puede dividir entre cero.");
            }

            Console.WriteLine($"El primer numero es par: {esPar}");
            Console.WriteLine("=======================");
        }
    }
}

/*
PRUEBA DE ESCRITORIO

Valores iniciales:
x = 10
y = 3

Operacion           Calculo           Resultado
Suma                10 + 3            13
Resta               10 - 3            7
Producto            10 * 3            30
Division real       10.0 / 3          3.33 aprox.
Division entera     10 / 3            3
Residuo             10 % 3            1
Es par (x)          10 % 2 == 0       true

*/