using System;

class Tarea
{
    public static string ExtraerSubcadena(string texto, int inicio, int longitud)
    {
        if (texto == null || texto.Length == 0)
            return "";

        if (inicio < 0 || longitud < 0)
            return "";

        if (inicio >= texto.Length)
            return "";

        if (inicio + longitud > texto.Length)
            longitud = texto.Length - inicio;

        char[] resultado = new char[longitud];

        for (int i = 0; i < longitud; i++)
            resultado[i] = texto[inicio + i];

        return new string(resultado);
    }

    static void Main()
    {
        string opcion = "";

        while (opcion != "n")
        {
            Console.Write("Texto: ");
            string texto = Console.ReadLine();

            Console.Write("Inicio: ");
            int inicio = int.Parse(Console.ReadLine());

        while (opcion != "n")
            Console.Write("Longitud: ");
            int longitud = int.Parse(Console.ReadLine());

            string resultado = ExtraerSubcadena(texto, inicio, longitud);

            Console.WriteLine("Resultado: " + resultado);
            Console.WriteLine();

            Console.Write("Otra vez? (s/n): ");
            opcion = Console.ReadLine();
        }
    }
}