namespace Interfaces.ex07;

public class Livro: IFretavel
{
    private  decimal valorFrete = 5;
    public void CalcularFrete(decimal distanciaKm)
    {
        Console.WriteLine("Valor do frete de livro é : " + valorFrete);
    }
}