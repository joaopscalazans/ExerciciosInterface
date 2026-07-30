namespace Interfaces.ex02;

public class Triangulo : IFormaGeometrica
{
    public double La { get; set; }
    public double Lb  { get; set; }
    public double Lc   { get; set; }
    
    public double Altura { get; set; }


    public Triangulo(double la, double lb, double lc, double altura)
    {
        La = la;
        Lb = lb;
        Lc = lc;
        Altura = altura;
    }

    public void CalcularArea()
    {
        Console.WriteLine($"A area do triangulo é: {((La * Altura)/2):F2}");
    }

    public void CalcularPerimetro()
    {
        Console.WriteLine($"O perimetro do triangulo é: {La + Lb + Lc}");
    }
}