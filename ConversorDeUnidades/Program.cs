using System;

namespace ConversorDeUnidades
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true; // Pista del ejercicio

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("CONVERSOR DE UNIDADES 1(Sistema Métrico)");
                Console.WriteLine("=======================================");
                Console.WriteLine("1. Kilómetros a Metros");
                Console.WriteLine("2. Metro a Centimetros");
                Console.WriteLine("3. Centimetros a Milimetros");
                Console.WriteLine("4. Metros a Pies");
                Console.WriteLine("5. Salir");
                Console.WriteLine("=======================================");
                Console.Write("Elija una opción:");

                string opcionStr = Console.ReadLine();
                int opcion;

                if (!int.TryParse(opcionStr, out opcion) || opcion < 1 || opcion > 5)
                {
                    Console.WriteLine("Opción no válida. Debe ser 1, 2, 3, 4 o 5");
                    Console.WriteLine("Presiona Enter para intentar de nuevo...");
                    Console.ReadLine();
                    continue;
                }

                switch (opcion)
                {
                    case 1: // km → m
                        Console.WriteLine("Ingresa la cantidad en kilometros (km): ");
                        string kmStr = Console.ReadLine();
                        double km;

                        if (!double.TryParse(kmStr, out km))
                        { 
                            Console.WriteLine("Entrada inválida. Debe ser un número.");
                            Console.WriteLine("Presiona Enter para intentar de nuevo...");
                            Console.ReadLine();
                            continue;
                        } 
                        
                        double metros = km * 1000;
                        Console.WriteLine($" {km} km = {metros} m ");
                        Console.WriteLine("Presiona Enter para continuar...");
                        Console.ReadLine();
                        break;

                    case 2: // m → cm
                        Console.WriteLine("Ingresa la cantidad en metros (m): ");
                        string inputString = Console.ReadLine();
                        double meters; 

                        if (!double.TryParse(inputString, out meters))
                        {
                            Console.WriteLine("Entrada inválida. Debe ser un número.");
                            Console.WriteLine("Presiona Enter para intentar de nuevo...");
                            Console.ReadLine();
                            continue;
                        }
                        double centimetros = meters * 100;
                        Console.WriteLine($" {meters} m = {centimetros} cm ");
                        Console.WriteLine("Presiona Enter para continuar...");
                        Console.ReadLine();
                        break;

                    case 3: // cm → mm
                        Console.WriteLine("Ingresa la cantidad en centimetros (cm): ");
                        string centimetersString = Console.ReadLine();
                        double centimeters;

                        if (!double.TryParse(centimetersString, out centimeters))
                        {
                            Console.WriteLine("Entrada inválida. Debe ser un número.");
                            Console.WriteLine("Presiona Enter para intentar de nuevo...");
                            Console.ReadLine();
                            continue;
                        }
                        double milimetros = centimeters * 10;
                        Console.WriteLine($" {centimeters} cm = {milimetros} mm ");
                        Console.WriteLine("Presiona Enter para continuar...");
                        Console.ReadLine();
                        break;

                    case 4: // m → pies
                        Console.WriteLine("Ingresa la cantidad en metros (m): ");
                        string metersString = Console.ReadLine();
                        double metersToConvert;

                        if (!double.TryParse(metersString, out metersToConvert))
                        {
                            Console.WriteLine("Entrada inválida. Debe ser un número.");
                            Console.WriteLine("Presiona Enter para intentar de nuevo...");
                            Console.ReadLine();
                            continue;
                        }
                        double pies = metersToConvert * 3.28084;
                        Console.WriteLine($" {metersToConvert} m = {pies:F2} pies ");
                        Console.WriteLine("Presiona Enter para continuar...");
                        Console.ReadLine();
                        break;

                    case 5:
                        Console.WriteLine("¡Gracias por usar el convertidor!");
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida");
                        Console.WriteLine("Presiona Enter para continuar...");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}