using System;
using System.Collections.Generic;
using System.IO;

namespace Jesus
{
    //  Calculadora
    public class Programa
    {
        static void Main()
        {
            List<string> historial = new List<string>();
            string archivo = "historial.txt";
            
            if (File.Exists(archivo))
            {
                historial = new List<string>(File.ReadAllLines(archivo));
                Console.WriteLine($"HISTORIAL Cargado: {historial.Count} operaciones");
                Console.ReadKey();
            }
            
            bool salirCalculadora = false;
            
            while (!salirCalculadora)
            {
                Console.Clear();
                Console.WriteLine("--- CALCULADORA ---");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Potencia");
                Console.WriteLine("6. Raiz cuadrada");
                Console.WriteLine("7. Ver historial");
                Console.WriteLine("8. Borrar historial");
                Console.WriteLine("9. Ver Estadisticas");
                Console.WriteLine("10. Salir de calculadora");
                Console.Write("Estas eligiendo:  ");
                
                int opcion;
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error: debes ingresar solo número");
                    Console.ReadKey();
                    continue;
                }
                
                if (opcion == 7) 
                {
                    Console.WriteLine("\n--- HISTORIAL ---");
                    if (historial.Count == 0)
                        Console.WriteLine("No hay operaciones");
                    else
                        foreach (string operacion in historial)
                            Console.WriteLine(operacion);
                    Console.ReadKey();
                }
                else if (opcion == 8) 
                {
                    historial.Clear();
                    File.Delete(archivo);
                    File.WriteAllText(archivo, "");
                    Console.WriteLine("Historial borrado");
                    Console.ReadKey();
                }
                else if (opcion == 9)
                {
                    Console.WriteLine("---Estadisticas---");
                    if (historial.Count == 0)
                    {
                        Console.WriteLine("--No hay historial --");
                    }
                    else
                    {
                        Console.WriteLine($"Total de historial: {historial.Count}");
                        int sumas = 0;
                        foreach (string operacion in historial)
                        {
                            if (operacion.Contains("+"))
                                sumas++;
                        }
                        Console.WriteLine($"Total de sumas hechas: {sumas}");
                        
                        double maximo = double.MinValue;
                        foreach (string operacion in historial)
                        {
                            int posIgual = operacion.IndexOf("=");
                            if (posIgual > 0)
                            {
                                string resultadoStr = operacion.Substring(posIgual + 1);
                                if (double.TryParse(resultadoStr, out double resultado))
                                {
                                    if (resultado > maximo)
                                        maximo = resultado;
                                }
                            }
                        }
                        if (maximo > double.MinValue)
                            Console.WriteLine($"El resultado mas alto: {maximo}");
                        
                        string ultima = historial[historial.Count - 1];
                        Console.WriteLine($"La ultima vez fue: {ultima} ");
                    }
                    Console.WriteLine("\nPresiona una tecla para seguir");
                    Console.ReadKey();
                }
                else if (opcion == 10)
                {
                    salirCalculadora = true;
                }
                else if (opcion >= 1 && opcion <= 6)
                {
                    double num1 = 0, num2 = 0;
                    
                    try
                    {
                        Console.Write("Número 1: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Número 2: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Error: números inválidos");
                        Console.ReadKey();
                        continue;
                    }
                    
                    string resultadoTexto = "";
                    
                    switch (opcion)
                    {
                        case 1:
                            double suma = num1 + num2;
                            resultadoTexto = $"{num1} + {num2} = {suma}";
                            Console.WriteLine(resultadoTexto);
                            break;
                        case 2:
                            double resta = num1 - num2;
                            resultadoTexto = $"{num1} - {num2} = {resta}";
                            Console.WriteLine(resultadoTexto);
                            break;
                        case 3:
                            double multi = num1 * num2;
                            resultadoTexto = $"{num1} * {num2} = {multi}";
                            Console.WriteLine(resultadoTexto);
                            break;
                        case 4:
                            if (num2 != 0)
                            {
                                double div = num1 / num2;
                                resultadoTexto = $"{num1} / {num2} = {div:F2}";
                                Console.WriteLine(resultadoTexto);
                            }
                            else
                            {
                                resultadoTexto = $"{num1} / 0 = ERROR";
                                Console.WriteLine("No se puede dividir por cero");
                            }
                            break;
                        case 5:
                            double potenc = Math.Pow(num1, num2);
                            resultadoTexto = $"{num1} ^ {num2} = {potenc}";
                            Console.WriteLine(resultadoTexto);
                            break;
                        case 6:
                            if (num1 >= 0)
                            {
                                double raiz = Math.Sqrt(num1);
                                resultadoTexto = $"√{num1} = {raiz}";
                                Console.WriteLine(resultadoTexto);
                            }
                            else
                            {
                                resultadoTexto = $"√{num1} = Error (Negativo)";
                                Console.WriteLine("No se puede por un numero negativo");
                            }
                            break;
                    }
                    
                    if (!string.IsNullOrEmpty(resultadoTexto))
                    {
                        historial.Add(resultadoTexto);
                        File.AppendAllText(archivo, resultadoTexto + Environment.NewLine);
                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Opción no válida");
                    Console.ReadKey();
                }
            }
        }
    }
}