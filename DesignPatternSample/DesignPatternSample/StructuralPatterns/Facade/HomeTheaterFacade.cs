namespace DesignPatternSample.StructuralPatterns.Facade;

public class HomeTheaterFacade
{
    private readonly DvdPlayer _dvdPlayer;
    private readonly Projector _projector;
    private readonly SurroundSoundSystem _surroundSoundSystem;

    public HomeTheaterFacade(DvdPlayer dvdPlayer, Projector projector, SurroundSoundSystem surroundSoundSystem)
    {
        _dvdPlayer = dvdPlayer;
        _projector = projector;
        _surroundSoundSystem = surroundSoundSystem;
    }
    
    public void WatchMovie(string movie)
    {
        Console.WriteLine("Get ready to watch a movie...");
        _projector.On();
        _projector.WideScreenMode();
        _surroundSoundSystem.On();
        _surroundSoundSystem.SetVolume(5);
        _dvdPlayer.On();
        _dvdPlayer.Play(movie);
    }

    public void EndMovie()
    {
        Console.WriteLine("Shutting movie theater down...");
        _projector.Off();
        _surroundSoundSystem.Off();
        _dvdPlayer.Off();
    }
}

