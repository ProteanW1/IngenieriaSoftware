using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear una lista de números
        List<int> numeros = new List<int>();

        // Solicitar al usuario que ingrese los números
        Console.WriteLine("Ingresa una lista de números separados por espacios (ejemplo: 5 2 8 1):");
        string entrada = Console.ReadLine();
        
        // Dividir la entrada en números y agregarlos a la lista
        string[] numerosStr = entrada.Split(' ');
        foreach (string numeroStr in numerosStr)
        {
            if (int.TryParse(numeroStr, out int numero))
            {
                numeros.Add(numero);
            }
        }

        // Ordenar la lista
        numeros.Sort();

        // Mostrar la lista ordenada
        Console.WriteLine("Lista ordenada de menor a mayor:");
        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }

        Console.WriteLine(); // Salto de línea al final
    }
}
