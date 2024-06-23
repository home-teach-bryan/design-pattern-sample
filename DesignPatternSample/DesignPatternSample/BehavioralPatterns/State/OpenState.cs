namespace DesignPatternSample.BehavioralPatterns.State;

public class OpenState : IState
{
    public void Open()
    {
        Console.WriteLine("Already opened");
    }

    public void Close()
    {
        Console.WriteLine("Closing the door");
    }

    public void Run()
    {
        Console.WriteLine("Cannot run when the door is open");
    }
}