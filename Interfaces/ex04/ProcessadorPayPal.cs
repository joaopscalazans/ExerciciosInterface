namespace Interfaces.ex04;

public class ProcessadorPayPal : IProcessarPagamento
{
    public void ProcessarPagamento(decimal valor)
    {
        Console.WriteLine("Pagamento de  " + valor + " via PayPal");
        Console.WriteLine("Processando Pagamento... ");
        Console.WriteLine("Verificando saldo na carteira digital");
        Console.WriteLine("Pagamento via PayPal processado com Sucesso");
    }

    public void CancelarPagamento()
    {
        Console.WriteLine("Cancelando Pagamento .....");
        Console.WriteLine("Seu pagamento foi cancelado");
    }
}