namespace Ejercicios.Ejercicios;

public class Calculadora
{
    /// <summary>
    /// Convierte una temperatura de grados Celsius a Fahrenheit.
    /// Fórmula: Celsius * 9/5 + 32
    /// </summary>
    public static double ConvertirCelsiusAFahrenheit(double celsius)
    {
        return (celsius * 1.8) + 32;
    }

    public static int Sumar(int numero1, int numero2)
    {
        return numero1 + numero2;
    }

    public static float Promediar(float valor1, float valor2, float valor3)
    {
        return (valor1 + valor2 + valor3) / 3;
    }
    
}