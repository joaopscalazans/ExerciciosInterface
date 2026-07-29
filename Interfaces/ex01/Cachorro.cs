namespace Interfaces.ex01;

public class Cachorro : IAnimal
{
    public void Falar()
    {
        Console.WriteLine("AuAu!");
    }

    public void Mover()
    {
        Console.WriteLine("Cachorro  andou");
    }
}