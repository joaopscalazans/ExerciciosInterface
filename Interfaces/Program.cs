using System.Runtime.InteropServices;
using Interfaces.ex01;
using Interfaces.ex02;
using Interfaces.ex03;
using Interfaces.ex04;
using Interfaces.ex05;
using Interfaces.ex06;
using Interfaces.ex07;
using Interfaces.ex08;
using Interfaces.ex09;

namespace Interfaces;

class Program
{
    static void Main(string[] args)
    {
        Ex01();
        Ex02();
        Ex03();
        Ex05();
        Ex06();
        Ex07();
        Ex08();
        Ex09();
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

    static void Ex04()
    {
        Console.WriteLine("============EX04=======");
        Console.WriteLine("!!! NESSE NÃO SABIA COMO IMPLEMENTAR, ENTÃO FICOU SO TEXTO MESMO !!!");

        List<IProcessarPagamento> pps = new List<IProcessarPagamento>
        {
            new ProcessadorBoleto(),
            new ProcessadorCardaoCerdido(),
            new ProcessadorPayPal()
        };

        foreach (var pp in pps)
        {
            if (pp is ProcessadorCardaoCerdido)
            {
                pp.CancelarPagamento();
            }
            else
            {
                pp.ProcessarPagamento(200);
            }
            
        }
    }
    
    static void Ex05()
    {
        Console.WriteLine("============EX05=======");
        new List<UnidosVeceremos.ITransport>
        {
            new UnidosVeceremos.Aviao(),
            new UnidosVeceremos.Carro(),
            new UnidosVeceremos.Trem()
        }.ForEach(x =>
        {
            Console.WriteLine(x.GetType().Name);
            x.ViagemDestino("Paris");
            x.FinalizarViagem();
        });
    }
    
    
    static void Ex06()
    {
        Console.WriteLine("============EX06=======");
        new List<INotificador>
        {
            new NotificadorEmail(),
            new NotificadorWhatsApp(),
            new NotificardorSMS()
        }
        .ForEach(x =>
        {
            Console.WriteLine();
            Console.WriteLine(x.GetType().Name);
            if(x is NotificadorEmail)
                x.EnviarMensagem("Foi autorizado no seu cartão Nubank um valor de R$2.000.\n Se foi o senhor(a) o autor do pagamento\n por favor nos encaminhar o cpf e os tres digitos na parte de trás do cartão", "Maria do Socorro");
            else if(x is NotificadorWhatsApp || x is NotificardorSMS)
                x.EnviarMensagem("Foi autorizado no seu cartão Nubank um valor de R$2.000.\n Se foi o senhor(a) o autor do pagamento\n por favor nos encaminhar o cpf e os tres digitos na parte de trás do cartão", "+559999999-9999");
        });
    }

    static void Ex07()
    {
        Console.WriteLine("============EX07=======");
        new List<IFretavel>
        {
            new Eletronico(),
            new Livro(),
            new Movel()
        }.ForEach(x => x.CalcularFrete(50));
    }
    
    static void Ex08()
    {
        Console.WriteLine("============EX08=======");
        Console.WriteLine("!! FEITO AO PE DA LETRA!!");
        new List<IAtacantes>
        {
            new Dragao(),
            new Mago(),
            new Paladino()
        }.ForEach(x =>
        {
            Console.WriteLine("Personagens que conseguem atacar");
            Console.WriteLine(x.GetType().Name);
        });
    }
    
    static void Ex09()
    {
        Console.WriteLine("============EX09=======");
        IRelatorios relatorios = null;
        IFormasBusca formasBusca = null;
      
        Console.WriteLine("Onde consultar");
            Console.WriteLine("1)  - Consultar no banco");
            Console.WriteLine("2)  - Consultar no arquivo X");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
             case "1":
                 formasBusca = new BancoDados();
                 break;
             case "2":
                 formasBusca = new Arquivo();
                 break;
            }
            
            Console.WriteLine("Tipo de relatorio");
            Console.WriteLine("1)  - PDF");
            Console.WriteLine("2)  - CSV");
            opcao = Console.ReadLine();
            
        
            switch (opcao)
            {
                case "1":
                    relatorios = new PDF();
                    break;
                case "2":
                    relatorios = new CSV();
                    break;
            }

            formasBusca.Buscar();
            relatorios.GerarRelatorio();
    }
    
    
}