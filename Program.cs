using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Por favor, ingresa tu nombre:");
        string nombre = Console.ReadLine();

     
        if (!string.IsNullOrEmpty(nombre))
        {
         
            char inicial = nombre[0];

        
            Console.WriteLine($"La inicial de tu nombre es: {inicial}");
        }

        }
    }

