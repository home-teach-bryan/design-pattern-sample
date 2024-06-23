using System.Reflection;

namespace DesignPatternSample.BehavioralPatterns.ChainOfResponsiblity;

public abstract class Leader
{
    protected string _name;
    protected Leader _next;

    protected Leader(string name)
    {
        this._name = name;
    }

    public void SetNext(Leader leader)
    {
        this._next = leader;
    }

    public Leader? GetNext()
    {
        return _next;
    }

    protected void LeaveApproved(int leaveDays)
    {
        Console.WriteLine($"{this._name} approved {leaveDays} days.");
    }

    protected void LeaveFailed()
    {
        Console.WriteLine("Too Many Leave Days, No one approved this leave");
    }
    
    public abstract void HandleRequest(int leaveDays); 
    
    
    
}