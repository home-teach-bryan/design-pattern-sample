namespace DesignPatternSample.BehavioralPatterns.State;

public class CloseState : IState
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