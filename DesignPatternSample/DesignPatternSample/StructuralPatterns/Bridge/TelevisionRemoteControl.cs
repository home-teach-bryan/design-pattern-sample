namespace DesignPatternSample.StructuralPatterns.Bridge;

public class TelevisionRemoteControl : RemoteControl
{
    public TelevisionRemoteControl(Television television) : base(television)
    {
    }

    public override void TurnOn()
    {
        base._television.TurnOn();
    }

    public override void TurnOff()
    {
        base._television.TurnOff();
    }

    public override void SetChannel(int channel)
    {
        base._television.SetChannel(channel);
    }
}