namespace Interfaces.ex04;

public class ProcessadorBoleto : IProcessarPagamento
{
    public void ProcessarPagamento(decimal valor)
    {
        Console.WriteLine("Pagamento de  " + valor + " pelo codigo de barras");
        Console.WriteLine("Processando Pagamento(pode levar até 3 dias uteis)....");
        Console.WriteLine("Pagamento via boleto processado com Sucesso");
    }

    public void CancelarPagamento()
    {
        Console.WriteLine("Cancelando Pagamento .....");
        Console.WriteLine("Seu pagamento foi cancelado");
    }
}