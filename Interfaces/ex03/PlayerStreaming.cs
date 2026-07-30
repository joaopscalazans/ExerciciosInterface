namespace Interfaces.ex03;

public class PlayerStreaming : IReprodutorMultimidia
{
    private List<string> transmissoes;
    private static int transmissao_tocando = -1;

    public PlayerStreaming()
    {
        transmissoes = new List<string>
        {
            "Transmissão de eSports",
            "Podcast Ao Vivo",
            "Noticiário 24h"
        };
    }

    public void Play()
    {
        transmissao_tocando = new Random().Next(transmissoes.Count);
        Console.WriteLine("Está tocando a transmissão : " + transmissoes[transmissao_tocando]);
    }

    public void Stop()
    {
        Console.WriteLine($"A transmissão {transmissoes[transmissao_tocando]} parou de reproduzir");
    }

    public void Pause()
    {
        Console.WriteLine($"A transmissão {transmissoes[transmissao_tocando]} foi pausada");
    }

    public void Avancar()
    { 
        int transmissao_nova = transmissao_tocando;
        do
        {
            transmissao_nova = new Random().Next(transmissoes.Count);
        } while (transmissao_nova == transmissao_tocando);

        transmissao_tocando = transmissao_nova;
        Console.WriteLine($"Avançou para a transmissão {transmissoes[transmissao_tocando]}");
    }
}