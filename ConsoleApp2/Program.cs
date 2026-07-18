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