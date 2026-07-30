namespace Interfaces.ex07;

public class Eletronico : IFretavel
{
    private decimal valorFrete = 1;
    public void CalcularFrete(decimal distanciaKm)
    {
        Console.WriteLine($"O valor do frete para Eletronicos é : {distanciaKm * valorFrete}");
    }
}