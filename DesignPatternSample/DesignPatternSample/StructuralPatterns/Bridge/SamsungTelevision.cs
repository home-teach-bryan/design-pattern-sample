namespace DesignPatternSample.StructuralPatterns.Bridge;

public class SamsungTelevision : Television
{
    public override void TurnOn()
    {
        Console.WriteLine("Samsung TV is turning on");
    }

    public override void TurnOff()
    {
        Console.WriteLine("Samsung TV is turning off");
    }

    public override void SetChannel(int channel)
    {
        Console.WriteLine("Samsung TV is set to channel " + channel);
    }
}