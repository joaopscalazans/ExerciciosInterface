namespace Interfaces.ex03;

public class PlayerVideo : IReprodutorMultimidia
{
    private List<string> videos;
    private static int video_tocando = -1;

    public PlayerVideo()
    {
        videos = new List<string>
        {
            "Tutorial C#",
            "Trailer do Filme",
            "Vídeo de Gatinhos"
        };
    }

    public void Play()
    {
        video_tocando = new Random().Next(videos.Count);
        Console.WriteLine("Está tocando o vídeo : " + videos[video_tocando]);
    }

    public void Stop()
    {
        Console.WriteLine($"O vídeo {videos[video_tocando]} parou de reproduzir");
    }

    public void Pause()
    {
        Console.WriteLine($"O vídeo {videos[video_tocando]} foi pausado");
    }

    public void Avancar()
    { 
        int video_novo = video_tocando;
        do
        {
            video_novo = new Random().Next(videos.Count);
        } while (video_novo == video_tocando);

        video_tocando = video_novo;
        Console.WriteLine($"Avançou para o vídeo {videos[video_tocando]}");
    }
}