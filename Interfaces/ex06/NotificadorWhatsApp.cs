namespace Interfaces.ex06;

public class NotificadorWhatsApp: INotificador
{
    public void EnviarMensagem(string mensagem, string destinatario)
    {
        Console.WriteLine($"""
                            () {destinatario}
                            
                            
                            {mensagem}
                            
                            
                                                
                            __________________________
                            |                     () |
                            _________________________
                          """);
                         
    }
}