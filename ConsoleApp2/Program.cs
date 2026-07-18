using System;

class Program
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


/*namespace ClaseCadenas;

class Program
{
    static void Main(string[] args)
    {
        string cadena = "HOLA MUNDO";
        Console.WriteLine(cadena);

        // Recorrer una cadena en orden inverso
        for (int i = cadena.Length - 1; i >= 0; i = i - 1)
        {
            Console.Write(cadena[i]);
        }

        Console.WriteLine();
        Console.WriteLine(Revertir(cadena));
        Console.WriteLine(AMinusculas(cadena));
    }

    public static string AMinusculas(string texto)
    {
        string resultado = "";
        for(int i = 0; i < texto.Length; i++)
        {
            if(texto[i] >= 'A' && texto[i] <= 'Z')
            {
                resultado += (char)(texto[i] + 32);
            }
            else
            {
                resultado += texto[i];
            }
        }

        return resultado;
    }

    public static string Revertir(string texto)
    {
        string resultado = "";
        for (int i = texto.Length - 1; i >= 0; i--)
        {
            resultado += texto[i];
            // resultado = resultado + texto[i];
        }

        return resultado;
    }
}
*/