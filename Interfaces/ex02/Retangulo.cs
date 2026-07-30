namespace Interfaces.ex02;

public class Retangulo : IFormaGeometrica
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    public Retangulo(double largura, double altura)
    {
        Largura = largura;
        Altura = altura;
    }

    public void CalcularArea()
    {
        Console.WriteLine($"A area do retangulo é : {(Altura * Largura):F2} ");
    }

    public void CalcularPerimetro()
    {
       Console.WriteLine($"O perimetro do retangulo é : {(2 * (Largura + Altura)):F2} ");
    }
}