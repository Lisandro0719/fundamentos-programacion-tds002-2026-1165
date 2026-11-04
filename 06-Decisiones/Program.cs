/*
Nombre: Lisandro
Fecha: 03/11/2026
Descripcion: Programa de calificaciones y calculadora
utilizando if, else if, else y switch.
*/

using System;

namespace _06_Decisiones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mostrar el menu principal.
            Console.WriteLine("===== PROGRAMA DE DECISIONES =====");
            Console.WriteLine("1. Calificacion");
            Console.WriteLine("2. Calculadora");
            Console.Write("Selecciona una opcion: ");

            string opcion = Console.ReadLine() ?? "";

            if (opcion == "1")
            {
                // Solicitar la nota.
                Console.Write("Introduce una nota de 0 a 100: ");
                string entradaNota = Console.ReadLine() ?? "";

                // Validar la nota utilizando TryParse.
                bool esValida = int.TryParse(entradaNota, out int nota);

                if (!esValida || nota < 0 || nota > 100)
                {
                    Console.WriteLine("Error: la nota debe estar entre 0 y 100.");
                }
                else
                {
                    // Asignar la letra correspondiente.
                    string letra;

                    if (nota >= 90)
                    {
                        letra = "A";
                    }
                    else if (nota >= 80)
                    {
                        letra = "B";
                    }
                    else if (nota >= 70)
                    {
                        letra = "C";
                    }
                    else
                    {
                        letra = "F";
                    }

                    Console.WriteLine($"Nota: {nota}");
                    Console.WriteLine($"Calificacion: {letra}");
                }
            }
            else if (opcion == "2")
            {
                // Solicitar dos numeros.
                Console.Write("Introduce el primer numero: ");
                double numeroUno = Convert.ToDouble(Console.ReadLine());

                Console.Write("Introduce el segundo numero: ");
                double numeroDos = Convert.ToDouble(Console.ReadLine());

                // Mostrar las operaciones.
                Console.WriteLine("\n===== CALCULADORA =====");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.Write("Selecciona una operacion: ");

                string operacion = Console.ReadLine() ?? "";

                // Realizar la operacion con switch.
                switch (operacion)
                {
                    case "1":
                        Console.WriteLine($"Resultado: {numeroUno + numeroDos:F2}");
                        break;

                    case "2":
                        Console.WriteLine($"Resultado: {numeroUno - numeroDos:F2}");
                        break;

                    case "3":
                        Console.WriteLine($"Resultado: {numeroUno * numeroDos:F2}");
                        break;

                    case "4":
                        // Comprobar division entre cero.
                        if (numeroDos == 0)
                        {
                            Console.WriteLine("Error: no se puede dividir entre cero.");
                        }
                        else
                        {
                            Console.WriteLine($"Resultado: {numeroUno / numeroDos:F2}");
                        }
                        break;

                    default:
                        Console.WriteLine("Operacion no valida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opcion no valida.");
            }
        }
    }
}