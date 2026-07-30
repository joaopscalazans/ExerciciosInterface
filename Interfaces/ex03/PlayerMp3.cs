namespace Interfaces.ex03;

public class PlayerMp3 : IReprodutorMultimidia
{
    private List<string> musicas;
    private static int musica_tocando = -1;

    public PlayerMp3()
    {
        musicas = new List<string>
        {
            "Bad guys",
            "Monster",
            "Baby Shark"
        };
    }
    public void Play()
    {
        musica_tocando = new Random().Next(musicas.Count);
        Console.WriteLine("Esta tocando a musica :  " + musicas[musica_tocando]);
    }

    public void Stop()
    {
        Console.WriteLine($"A musica {musicas[musica_tocando]} parou de tocar");
    }

    public void Pause()
    {
        Console.WriteLine($"A musica {musicas[musica_tocando]} esta pausado");
    }

    public void Avancar()
    { 
        int musica_nova = musica_tocando;
        do
        {
            musica_nova = new Random().Next(musicas.Count);
        } while (musica_nova == musica_tocando);
        musica_tocando = musica_nova;
        Console.WriteLine($"Avançou para a musica {musicas[musica_tocando]}");
    }
}