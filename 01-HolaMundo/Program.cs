/*
 * Nombre: Lisandro Muñoz
 * Fecha: 26/10/2026
 * Descripción: Programa de consola que muestra mi tarjeta de
 *              presentación con un marco de caracteres.
 */

namespace HolaMundo;

internal class Program
{
    static void Main(string[] args)
    {
        // Datos personales
        string nombre = "Lisandro Muñoz";
        string matricula = "2026-1165";
        string carrera = "Ciberseguridad";
        string frase = "La programación es mi pasión.";

        // Ancho interior de la tarjeta
        int ancho = 56;

        // Borde superior e inferior con asteriscos
        string borde = new string('*', ancho + 4);
        string separador = "*" + new string('=', ancho + 2) + "*";

        Console.WriteLine(borde);
        Console.WriteLine(Linea("TARJETA DE PRESENTACIÓN", ancho));
        Console.WriteLine(separador);
        Console.WriteLine(Linea("Nombre: " + nombre, ancho));
        Console.WriteLine(Linea("Matrícula: " + matricula, ancho));
        Console.WriteLine(Linea("Carrera: " + carrera, ancho));
        Console.WriteLine(separador);
        Console.WriteLine(Linea("\"" + frase + "\"", ancho));
        Console.WriteLine(borde);
    }

    // Arma una línea con barras laterales y el texto ajustado al ancho
    static string Linea(string texto, int ancho)
    {
        return "| " + texto.PadRight(ancho) + " |";
    }
}
