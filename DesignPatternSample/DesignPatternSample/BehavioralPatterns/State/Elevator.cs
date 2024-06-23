namespace DesignPatternSample.BehavioralPatterns.State;

public class Elevator
{
    private IState _state;

    public Elevator()
    {
        this._state = new CloseState();
    }
    
    public void ChangeState(IState state)
    {
        _state = state;
    }

    public void Open()
    {
        _state.Open();
    }

    public void Close()
    {
        _state.Close();
    }

    public void Run()
    {
        _state.Run();
    }
}