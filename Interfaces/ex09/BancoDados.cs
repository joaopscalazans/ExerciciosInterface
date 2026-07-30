namespace Interfaces.ex09;

public class BancoDados : IFormasBusca
{
    public void Buscar()
    {
        Console.WriteLine("Fazendo query no banco de dados");
    }
}