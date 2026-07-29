using Interfaces.ex01;
using Interfaces.ex02;

namespace Interfaces;

class Program
{
    static void Main(string[] args)
    {
        Ex01();
        Ex02();
    }

    static void Ex01()
    { 
        Console.WriteLine("===========EX01==========");
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

    static void Ex02()
    {
        Console.WriteLine("===========EX02==========");
        List<IFormaGeometrica> formas = new List<IFormaGeometrica>
        {
            new Circulo(10),
            new Retangulo(8, 5),
            new Triangulo(3, 4, 5, 4)
        };

        foreach (var forma in formas)
        {
            Console.WriteLine("--------");
            forma.CalcularPerimetro();
            forma.CalcularArea();
            Console.WriteLine("--------");
        }
        
        Console.WriteLine();
    }
}