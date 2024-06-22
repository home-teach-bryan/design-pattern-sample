namespace DesignPatternSample.StructuralPatterns.Facade;

public class DvdPlayer
{
    public void On()
    {
        Console.WriteLine("DVD Player is On");
    }

    public void Off()
    {
        Console.WriteLine("DVD Player is Off");
    }

    public void Play(string movie)
    {
        Console.WriteLine($"Playing {movie}");
    }
}