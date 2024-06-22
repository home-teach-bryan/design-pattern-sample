namespace DesignPatternSample.StructuralPatterns.Facade;

public class Projector
{
    public void On()
    {
        Console.WriteLine("Projector is On");
    }

    public void Off()
    {
        Console.WriteLine("Projector is Off");
    }

    public void WideScreenMode()
    {
        Console.WriteLine("Projector in widescreen mode (16x9 aspect ratio)");
    }
}