namespace Interfaces.ex06;

public class NotificadorEmail : INotificador
{
    public void EnviarMensagem(string mensagem, string destinatario)
    {
        Console.WriteLine("De: tanana@gmail.com");
        Console.WriteLine($"Para: {destinatario}");
        Console.WriteLine($"[\n{mensagem}\n]");
    }
}