using Interfaces.ex01;

namespace Interfaces;

class Program
{
    static void Main(string[] args)
    {
        Ex01();
    }

    static void Ex01()
    {
        Console.WriteLine("Falar ===============");
        new List<IAnimal>
        {
            new Cachorro(),
            new Gato(),
            new Passaro()
        }.ForEach(animal => animal.Falar());
        Console.WriteLine("Mover ===============");
        new List<IAnimal>
        {
            new Cachorro(),
            new Gato(),
            new Passaro()
        }.ForEach(animal => animal.Mover());
        Console.WriteLine();
    }
}