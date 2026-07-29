namespace Interfaces.ex01;

public class Passaro : IAnimal
{
    public void Falar()
    {
        Console.WriteLine("PiuPiu!");
    }

    public void Mover()
    {
        Console.WriteLine("O passaro bateu asa pra algum lugar");
    }
}