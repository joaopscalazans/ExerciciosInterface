namespace Interfaces.ex04;

public interface IProcessarPagamento
{
    void ProcessarPagamento(decimal valor);
    void CancelarPagamento();

}