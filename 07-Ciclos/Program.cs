/*
Nombre: Lisandro
Fecha: 03/11/2026
Descripcion: Programa que solicita un numero del 1 al 12,
lo valida utilizando do-while, muestra su tabla de
multiplicar con while y calcula la suma de los resultados.
*/

using System;

namespace _07_Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarar las variables.
            int numero;
            int contador = 1;
            int acumulador = 0;
            int resultado;
            bool entradaValida;

            // Solicitar y validar el numero con do-while.
            do
            {
                Console.Write("Introduce un numero entre 1 y 12: ");

                string entrada = Console.ReadLine() ?? "";

                entradaValida = int.TryParse(entrada, out numero);

                if (!entradaValida || numero < 1 || numero > 12)
                {
                    Console.WriteLine("Error: debes introducir un numero entero entre 1 y 12.");
                }

            } while (!entradaValida || numero < 1 || numero > 12);

            // Mostrar el titulo de la tabla.
            Console.WriteLine($"\n===== TABLA DEL {numero} =====");

            // Generar la tabla de multiplicar con while.
            while (contador <= 12)
            {
                resultado = numero * contador;

                // Mostrar cada multiplicacion.
                Console.WriteLine($"{numero} x {contador} = {resultado}");

                // Acumular los resultados.
                acumulador = acumulador + resultado;

                // Aumentar el contador.
                contador++;
            }

            // Mostrar la suma de todos los resultados.
            Console.WriteLine("========================");
            Console.WriteLine($"Suma de los resultados: {acumulador}");
            Console.WriteLine("========================");
        }
    }
}