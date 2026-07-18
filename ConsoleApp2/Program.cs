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


/*public static string ExreaerSubcadena(string texto, int inicio, int longitud)
{
    throw new NotImplementedException();
}

{
    //Verificar si el texto es nulo o vacío0>Program.cs(97,6): Error CS1513 : Se esperaba }

    object texto;
    if (texto == null || texto) ;
    {
        return "";
    }
}using System;

class Program
{
    public static string ExtraerSubcadena(string texto, int inicio, int longitud)
    {
        if (texto == null || texto.Length == 0)
            return "";

        if (inicio < 0 || longitud < 0)
            return "";
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
            Consousing System;

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
}le.Write("Texto: ");
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
        string using System;

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
}opcion = "";

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

namespace ClaseCadenas;

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
        for (int i = 0; i < texto.Length; i++)
        {
            if (texto[i] >= 'A' && texto[i] <= 'Z')
            {
                resultado += (char)(texto[i] + 32);
            }
            else
            {
                resultado += texto[i];
            }using System;

class Program
{
    public static string ExtraerSubcadena(string texto, int inicio, int longitud)
    {
        if (texusing System;

class Program
{
    public static string ExtraerSubcadena(string texto, int inicio, int longitud)
    {
        if (texto == null || texto.Length == 0)
            return "";

        if (iniusing System;

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
}cio < 0 || longitud < 0)
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
}to == null || texto.Length == 0)
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

        return using System;

class Program
{
    public static string ExtraerSubcadena(string texto, int inicio, int longitud)
    {
        if (texto == null || texto.Length == 0)
            return "";

        if (iniusing System;

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
}cio < 0 || longitud < 0)
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
}resultado;
    }

    public static string Revertir(string texto)
    {
        string resultado = "";
        int i = texto.Length - 1;
        for (; i >= 0; i--)
        {
            resultado += texto[i];
            // resultado = resultado + texto[i];
        }

        return resultado;
    }

    public static string ExtraerSubcadena(string texto, int inicio, int longitud)
    {
        // Verificar si el texto es nulo o vacío
        if (texto == null || texto == "")
        {
            return "";
        }

        // Verificar si el índice o la longitud son negativos
        if (inicio < 0 || longitud < 0)
        {
            return "";
        }

        // Verificar si el inicio está fuera del rango
        if (inicio >= texto.Length)
        {
            return "";
        }

        // Variable donde se guardará0>Program.cs(97,6): Error CS1513 : Se esperaba }
 la subcadena
        string resultado = "";

        // Recorrer el texto y copiar los caracteres
        for (int i = inicio; i < inicio + longitud && i < texto.Length; i++)
        {
            resultado += texto[i];
        }

        // Regresar el resultado
        return resultado;
    }
    */
