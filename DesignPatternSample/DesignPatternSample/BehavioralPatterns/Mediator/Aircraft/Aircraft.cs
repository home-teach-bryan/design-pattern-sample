namespace DesignPatternSample.BehavioralPatterns.Mediator;

public abstract class Aircraft
{
    protected readonly IAirTrafficMediator _airTrafficMediator;
    public string Name { get; }

    protected Aircraft(IAirTrafficMediator airTrafficMediator, string name)
    {
        _airTrafficMediator = airTrafficMediator;
        this.Name = name;
    }
    
    public abstract void RequestLanding();
    public abstract void RequestTakeoff();
}