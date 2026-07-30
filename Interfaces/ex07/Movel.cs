namespace Interfaces.ex07;

public class Movel : IFretavel
{
    private decimal valorFrete = (decimal)2.50;
    private decimal taxaFixa = 20;
    public void CalcularFrete(decimal distanciaKm)
    {
        var calculo = distanciaKm * valorFrete +  taxaFixa;
        Console.WriteLine("O frete para moveis fica de: " + calculo);
    }
}