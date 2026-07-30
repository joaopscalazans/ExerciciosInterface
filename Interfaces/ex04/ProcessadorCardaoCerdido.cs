namespace Interfaces.ex04;

public class ProcessadorCardaoCerdido : IProcessarPagamento
{
    public void ProcessarPagamento(decimal valor)
    {
        Console.WriteLine("Pagamento de  " + valor + " via cartão de cretido");
        Console.WriteLine("Processando Pagamento... ");
        Console.WriteLine("Verificando limite disponivel");
        Console.WriteLine("Pagamento via cartão de cerdito Processado com Sucesso");
    }

    public void CancelarPagamento()
    {
        Console.WriteLine("Cancelando Pagamento .....");
        Console.WriteLine("Seu pagamento foi cancelado");
    }
}