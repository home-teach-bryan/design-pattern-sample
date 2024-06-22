namespace DesignPatternSample.StructuralPatterns.Facade;

public class SurroundSoundSystem
{
    public void On()
    {
        Console.WriteLine("Surround Sound System is On");
    }

    public void Off()
    {
        Console.WriteLine("Surround Sound System is Off");
    }

    public void SetVolume(int level)
    {
        Console.WriteLine($"Surround Sound System volume set to {level}");
    }
}