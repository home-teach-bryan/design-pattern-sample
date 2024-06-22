namespace DesignPatternSample.StructuralPatterns.Adapter;

public class UsaPowerPlug : IUsaPowerPlug
{
    public void PlugInOutlet()
    {
        Console.WriteLine("Plugging in to USA outlet.");
    }
}