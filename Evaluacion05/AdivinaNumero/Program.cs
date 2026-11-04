/*
Nombre: Lisandro
Descripcion: Juego para adivinar un numero secreto
utilizando Random, while y un contador.
*/

using System;

namespace AdivinaNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generar un numero secreto entre 1 y 100.
            int numeroSecreto = Random.Shared.Next(1, 101);

            // Inicializar las variables.
            int numeroUsuario = 0;
            int intentos = 0;

            Console.WriteLine("===== ADIVINA EL NUMERO =====");
            Console.WriteLine("Estoy pensando en un numero del 1 al 100.");

            // Repetir hasta adivinar el numero.
            while (numeroUsuario != numeroSecreto)
            {
                Console.Write("\nIntroduce tu numero: ");
                string? entrada = Console.ReadLine();

                if (entrada == null)
                {
                    Console.WriteLine("Juego finalizado.");
                    return;
                }

                // Validar el numero ingresado.
                bool esValido = int.TryParse(
                    entrada, out numeroUsuario
                );

                if (!esValido || numeroUsuario < 1 || numeroUsuario > 100)
                {
                    Console.WriteLine("Error: introduce un numero entre 1 y 100.");
                    continue;
                }

                // Contar cada intento valido.
                intentos++;

                // Comparar con el numero secreto.
                if (numeroUsuario < numeroSecreto)
                {
                    Console.WriteLine("El numero secreto es MAYOR.");
                }
                else if (numeroUsuario > numeroSecreto)
                {
                    Console.WriteLine("El numero secreto es MENOR.");
                }
                else
                {
                    Console.WriteLine("\n¡Felicidades! Adivinaste el numero.");
                    Console.WriteLine($"Numero secreto: {numeroSecreto}");
                    Console.WriteLine($"Cantidad de intentos: {intentos}");
                }
            }
        }
    }
}