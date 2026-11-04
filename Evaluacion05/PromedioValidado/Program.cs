/*
Nombre: Lisandro
Descripcion: Programa que registra notas validas,
calcula su promedio y encuentra la mayor y menor.
*/

using System;

namespace PromedioValidado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarar las variables.
            int nota = 0;
            int cantidadNotas = 0;
            int sumaNotas = 0;
            int notaMayor = 0;
            int notaMenor = 0;
            bool esValida;

            Console.WriteLine("===== PROMEDIO DE NOTAS =====");
            Console.WriteLine("Escribe -1 para finalizar.\n");

            // Solicitar notas hasta recibir -1.
            while (true)
            {
                // Validar cada nota con do-while.
                do
                {
                    Console.Write("Introduce una nota (0-100): ");
                    string? entrada = Console.ReadLine();

                    if (entrada == null)
                    {
                        Console.WriteLine("Entrada finalizada.");
                        return;
                    }

                    esValida = int.TryParse(entrada, out nota);

                    if (!esValida || (nota != -1 && (nota < 0 || nota > 100)))
                    {
                        Console.WriteLine("Error: introduce una nota de 0 a 100 o -1 para terminar.");
                        esValida = false;
                    }

                } while (!esValida);

                // Terminar cuando el usuario introduce -1.
                if (nota == -1)
                {
                    break;
                }

                // Acumular la nota y contarla.
                sumaNotas += nota;
                cantidadNotas++;

                // Inicializar mayor y menor con la primera nota.
                if (cantidadNotas == 1)
                {
                    notaMayor = nota;
                    notaMenor = nota;
                }
                else
                {
                    // Actualizar la nota mayor.
                    if (nota > notaMayor)
                    {
                        notaMayor = nota;
                    }

                    // Actualizar la nota menor.
                    if (nota < notaMenor)
                    {
                        notaMenor = nota;
                    }
                }

                Console.WriteLine("Nota registrada correctamente.\n");
            }

            // Evitar division entre cero.
            if (cantidadNotas > 0)
            {
                double promedio = (double)sumaNotas / cantidadNotas;

                // Mostrar los resultados con dos decimales.
                Console.WriteLine("\n===== RESULTADOS =====");
                Console.WriteLine($"Cantidad de notas: {cantidadNotas}");
                Console.WriteLine($"Promedio: {promedio:F2}");
                Console.WriteLine($"Nota mayor: {notaMayor}");
                Console.WriteLine($"Nota menor: {notaMenor}");
                Console.WriteLine("======================");
            }
            else
            {
                Console.WriteLine("No se registraron notas.");
            }
        }
    }
}