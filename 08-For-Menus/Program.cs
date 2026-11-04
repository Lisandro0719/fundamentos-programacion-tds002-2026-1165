/*
Nombre: Lisandro
Descripcion: Programa que muestra tablas de multiplicar
y dibuja triangulos de asteriscos utilizando ciclos
for anidados, do-while y switch.
*/

using System;

namespace _08_For_Menus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable para almacenar la opcion del menu.
            string opcion;

            // Repetir el menu hasta que el usuario elija salir.
            do
            {
                Console.WriteLine("\n===== MENU PRINCIPAL =====");
                Console.WriteLine("1. Tablas de multiplicar");
                Console.WriteLine("2. Triangulo de asteriscos");
                Console.WriteLine("0. Salir");
                Console.Write("Selecciona una opcion: ");

                opcion = Console.ReadLine() ?? "0";

                // Ejecutar la opcion seleccionada.
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("\n===== TABLAS DEL 1 AL 10 =====\n");

                        // Mostrar los encabezados de cada tabla.
                        for (int tabla = 1; tabla <= 10; tabla++)
                        {
                            Console.Write($"{tabla,4}");
                        }

                        Console.WriteLine();

                        // Ciclo exterior: multiplicadores del 1 al 10.
                        for (int fila = 1; fila <= 10; fila++)
                        {
                            // Ciclo interior: tablas del 1 al 10.
                            for (int tabla = 1; tabla <= 10; tabla++)
                            {
                                int resultado = tabla * fila;

                                // Mostrar resultados en columnas alineadas.
                                Console.Write($"{resultado,4}");
                            }

                            Console.WriteLine();
                        }

                        break;

                    case "2":
                        // Solicitar el numero de filas.
                        Console.Write("\nIntroduce el numero de filas: ");
                        string entrada = Console.ReadLine() ?? "";

                        // Validar que sea un entero positivo.
                        bool esValido = int.TryParse(
                            entrada, out int numeroFilas
                        );

                        if (!esValido || numeroFilas <= 0)
                        {
                            Console.WriteLine("Error: introduce un numero entero positivo.");
                        }
                        else
                        {
                            Console.WriteLine("\n===== TRIANGULO =====");

                            // Ciclo exterior: controla las filas.
                            for (int fila = 1; fila <= numeroFilas; fila++)
                            {
                                // Ciclo interior: dibuja los asteriscos.
                                for (int columna = 1; columna <= fila; columna++)
                                {
                                    Console.Write("*");
                                }

                                // Pasar a la siguiente fila.
                                Console.WriteLine();
                            }
                        }

                        break;

                    case "0":
                        Console.WriteLine("\nGracias por utilizar el programa.");
                        Console.WriteLine("Programa finalizado.");
                        break;

                    default:
                        Console.WriteLine("Error: selecciona una opcion valida.");
                        break;
                }

            } while (opcion != "0");
        }
    }
}
