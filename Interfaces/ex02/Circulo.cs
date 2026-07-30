namespace Interfaces.ex02;

public class Circulo : IFormaGeometrica
{
    public double Raio { get; set; }

    public Circulo(double raio)
    {
        Raio = raio;
    }

    public void CalcularArea()
        => Console.WriteLine($"A area do circulo é : {(Math.PI * Math.Pow(Raio, 2)):F2}");
    

    public void CalcularPerimetro()
     => Console.WriteLine($"O perimetro do circulo é : {(2 * Math.PI * Raio):F2}");
}