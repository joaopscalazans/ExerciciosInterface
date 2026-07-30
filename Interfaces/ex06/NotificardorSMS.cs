namespace Interfaces.ex06;

public class NotificardorSMS: INotificador
{
    public void EnviarMensagem(string mensagem, string destinatario)
    {
        Console.WriteLine($"""
            <- {destinatario}
            --------------------------------------
            
            -----------------Não lidas------------
                            {DateTime.Now}
                            
            {mensagem}
            
            __________________________
            |                      |
            _________________________
          """);
    }
}