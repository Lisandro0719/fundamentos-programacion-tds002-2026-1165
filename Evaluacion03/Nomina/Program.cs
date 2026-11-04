
/*
Nombre: Lisandro
Fecha: 03/11/2026
Descripcion: Programa que calcula el salario bruto,
los descuentos de AFP y SFS, y el salario neto.
*/

using System;
using System.Globalization;

namespace Nomina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarar las constantes de descuentos.
            const decimal TASA_AFP = 0.0287m;
            const decimal TASA_SFS = 0.0304m;

            // Solicitar el nombre del empleado.
            Console.Write("Introduce el nombre del empleado: ");
            string nombre = Console.ReadLine() ?? "";

            // Solicitar las horas trabajadas.
            Console.Write("Introduce las horas trabajadas: ");
            decimal horasTrabajadas = decimal.Parse(
                (Console.ReadLine() ?? "0").Replace(',', '.'),
                CultureInfo.InvariantCulture
            );

            // Solicitar el pago por hora.
            Console.Write("Introduce el pago por hora: RD$ ");
            decimal pagoPorHora = decimal.Parse(
                (Console.ReadLine() ?? "0").Replace(',', '.'),
                CultureInfo.InvariantCulture
            );

            // Calcular el salario bruto.
            decimal salarioBruto = horasTrabajadas * pagoPorHora;

            // Calcular los descuentos.
            decimal descuentoAfp = salarioBruto * TASA_AFP;
            decimal descuentoSfs = salarioBruto * TASA_SFS;

            // Calcular el salario neto.
            decimal salarioNeto = salarioBruto - descuentoAfp - descuentoSfs;

            // Convertir el nombre a mayusculas.
            string nombreMayusculas = nombre.ToUpperInvariant();

            // Mostrar los resultados con dos decimales.
            Console.WriteLine("\n========== NOMINA ==========");
            Console.WriteLine($"Empleado: {nombreMayusculas}");
            Console.WriteLine($"Horas trabajadas: {horasTrabajadas:N2}");
            Console.WriteLine($"Pago por hora: RD$ {pagoPorHora:N2}");
            Console.WriteLine($"Salario bruto: RD$ {salarioBruto:N2}");
            Console.WriteLine($"AFP (2.87%): RD$ {descuentoAfp:N2}");
            Console.WriteLine($"SFS (3.04%): RD$ {descuentoSfs:N2}");
            Console.WriteLine($"Salario neto: RD$ {salarioNeto:N2}");
            Console.WriteLine("============================");
        }
    }
}