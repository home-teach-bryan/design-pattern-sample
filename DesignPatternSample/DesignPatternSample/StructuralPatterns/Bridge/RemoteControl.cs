
namespace DesignPatternSample.StructuralPatterns.Bridge;

public abstract class RemoteControl
{
    protected Television _television;

    protected RemoteControl(Television television)
    {
        _television = television;
    }

    public abstract void TurnOn();
    public abstract void TurnOff();
    public abstract void SetChannel(int channel);

}