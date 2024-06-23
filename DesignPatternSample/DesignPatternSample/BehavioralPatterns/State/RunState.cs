namespace DesignPatternSample.BehavioralPatterns.State;

public class RunState : IState
{
    public void Open()
    {
        Console.WriteLine("Opening the door");
    }

    public void Close()
    {
        Console.WriteLine("Already closed");
    }

    public void Run()
    {
        Console.WriteLine("Running");
    }
}