namespace Interfaces.ex01;

public class Gato : IAnimal
{
    public void Falar()
    {
        Console.WriteLine("Miauu!");
    }

    public void Mover()
    {
        Console.WriteLine("O gato andou");
    }
}