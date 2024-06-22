namespace DesignPatternSample.StructuralPatterns.Bridge;

public class SonyTelevision : Television
{
    public override void TurnOn()
    {
        Console.WriteLine("Sony TV is turning on");
    }

    public override void TurnOff()
    {
        Console.WriteLine("Sony TV is turning off");
    }

    public override void SetChannel(int channel)
    {
        Console.WriteLine("Sony TV is set to channel " + channel);
    }
}