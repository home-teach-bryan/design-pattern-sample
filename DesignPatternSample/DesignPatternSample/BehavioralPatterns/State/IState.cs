namespace DesignPatternSample.BehavioralPatterns.State;

public interface IState
{
    void Open();
    void Close();
    void Run();
}