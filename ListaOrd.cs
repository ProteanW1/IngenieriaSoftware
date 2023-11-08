using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Saludo al usuario
        Console.Write("Por favor, ingresa tu nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine($"Hola, {nombre}!");

        // Obtener la lista de números
        Console.WriteLine("Ingresa tres números separados por espacios (ejemplo: 5 2 8):");
        string entrada = Console.ReadLine();

        // Dividir la entrada en números y agregarlos a una lista
        List<int> numeros = entrada.Split(' ').Select(int.Parse).ToList();

        // Verificar si se ingresaron tres números
        if (numeros.Count != 3)
        {
            Console.WriteLine("Debes ingresar exactamente tres números.");
        }
        else
        {
            // Ordenar la lista
            numeros.Sort();

            // Mostrar la lista ordenada
            Console.WriteLine("Lista ordenada de menor a mayor:");
            foreach (int numero in numeros)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();

            // Encontrar el número mayor y el número menor
            int numeroMayor = numeros[numeros.Count - 1];
            int numeroMenor = numeros[0];
            Console.WriteLine($"Número mayor: {numeroMayor}");
            Console.WriteLine($"Número menor: {numeroMenor}");
        }
    }
}
