using System;
using System.IO;
using Microsoft.VisualBasic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la ruta completa donde desea crear el archivo (incluyendo el nombre de archivo y la extensión, por ejemplo: C:/Users/Any/Documents/text.txt):");
        string? ruta = Console.ReadLine();

        Console.WriteLine("Ingrese el texto que desea escribir en el archivo:");
        string? texto = Console.ReadLine();

        try
        {
            if (File.Exists(ruta))
            {
                Console.WriteLine("El archivo ya existe. ¿Desea sobrescribirlo? (S/N)");
                if (Console.ReadKey().Key != ConsoleKey.S)
                {
                    Console.WriteLine("\nOperación cancelada.");
                    return;
                }
                Console.WriteLine();
            }

            File.WriteAllText(ruta, texto);

            Console.WriteLine($"Se ha creado el archivo \"{ruta}\" con el contenido proporcionado.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Se produjo un error al intentar crear el archivo: {ex.Message}");
        }
    }
}
