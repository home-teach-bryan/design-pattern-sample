namespace DesignPatternSample.StructuralPatterns.Bridge;

public abstract class Television
{
    public abstract void TurnOn();
    public abstract void TurnOff();
    public abstract void SetChannel(int channel);
}