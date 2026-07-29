using Interfaces.ex01;
using Interfaces.ex02;
using Interfaces.ex03;

namespace Interfaces;

class Program
{
    static void Main(string[] args)
    {
        Ex01();
        Ex02();
        Ex03();
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

    static void Ex03()
    {
        Console.WriteLine("============EX03=======");
        List<IReprodutorMultimidia> rms = new List<IReprodutorMultimidia>
        {
            new PlayerMp3(),
            new PlayerStreaming(),
            new PlayerVideo()
        };

        foreach (var rm in rms)
        {
            if (rm is PlayerStreaming streaming)
            {
                Console.WriteLine("PlayerStreaming");
            }
            else if (rm is PlayerVideo vid)
            {
                Console.WriteLine("PlayerVideo");
            }else if (rm is PlayerMp3 mp3)
            {
                Console.WriteLine("PlayerMp3");
            }
            
            rm.Play();
            rm.Pause();
            rm.Avancar();
            rm.Play();
            rm.Stop();
            Console.WriteLine();
        }
        
        Console.WriteLine();
    }
}