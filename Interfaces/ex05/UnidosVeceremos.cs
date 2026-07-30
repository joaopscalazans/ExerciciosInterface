namespace Interfaces.ex05;



public class UnidosVeceremos
{
    public interface ITransport
    {
        void ViagemDestino(string destino);
        void FinalizarViagem();
    }

    public class Carro : ITransport
    {
        public void ViagemDestino(string destino)
        {
            Console.WriteLine($"O Gps está calculando a melhor toda possivel para {destino}");
        }

        public void FinalizarViagem()
        {
           Console.WriteLine($"Você chegou ao seu destino!!");
        }
    }

    public class Aviao : ITransport
    {
        public void ViagemDestino(string destino)
            => Console.WriteLine($"Levantando vooo \n Indo para o aeroporto  de {destino}");

        public void FinalizarViagem() => Console.WriteLine("Pousando no aeroporto!");
    }
    
    public class Trem : ITransport
    {
        public void ViagemDestino(string destino) => Console.WriteLine($"Indo até a estação de {destino}");

        public void FinalizarViagem() => Console.WriteLine($"Senhores passageiros chegamos na estação!!");
    }
}