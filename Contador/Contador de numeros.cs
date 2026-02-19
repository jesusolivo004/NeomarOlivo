using System;
using System.Collections.Generic;

namespace Jesus
{
    //  --- mi menu ---
    public class HolaMundo
    {
        static void Main()
        {
            bool salir = false;
            
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=== MI PROGRAMA ===");
                Console.WriteLine("1. vemos numeros?");
                Console.WriteLine("2. Salir");
                Console.Write("Elige: ");
                
                string opcion = Console.ReadLine();
                
                else if (opcion == "1")
                {
                     Console.WriteLine("\n=== CONTANDO ===");
                     for (int i = 1; i <= 100; i++) 
                     {
                     Console.WriteLine($"Número: {i}");
                     }
                     Console.WriteLine("\nPresiona una tecla para continuar...");
                     Console.ReadKey();
                 }
                else if (opcion == "2")
                {
                    salir = true;
                }
                else
                {
                    Console.WriteLine("Opción no válida");
                    Console.ReadKey();
                }
            }
        }
    }
    
