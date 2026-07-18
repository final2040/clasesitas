using Ejercicios.Ejercicios;

namespace Ejercicios;

[TestFixture]
public class EjerciciosCalculadora
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(1, 2, 3)]
    [TestCase(50, 20, 70)]
    [TestCase(88, 72, 160)]
    [TestCase(-10, -20, -30)]
    public void Sumar_DeberiaRetornarElValorCorrecto(int a, int b, int esperado)
    {
        // act
        int resultado = Calculadora.Sumar(a, b);
        
        // assert
        Assert.That(resultado, Is.EqualTo(esperado));
    }

    [Test]
    [TestCase(0, 32)]
    [TestCase(100, 212)]
    [TestCase(-40, -40)]
    [TestCase(37.5, 99.5)]
    public void ConvertirCelsiusAFahrenheit_DeberiaRetornarElValorCorrecto(double celsius, double esperado)
    {
        // Act
        double resultado = Calculadora.ConvertirCelsiusAFahrenheit(celsius);
        
        // Arrange
        Assert.That(resultado, Is.EqualTo(esperado));
    }

    [Test]
    [TestCase(10F, 10F, 10F, 10F)]
    [TestCase(10F, 5F, 8F, 7.66F)]
    [TestCase(178F, 89F, 544F, 270.33F)] 
    public void CalcularPromedio_DeberiaRetornarElPromedio(float valor1, float valor2, float valor3, float esperado)
    {
        // Act
        float resultado = Calculadora.Promediar(valor1, valor2, valor3);
        
        // Assert
        Assert.That(resultado, Is.EqualTo(esperado).Within(0.01F));
    }
}