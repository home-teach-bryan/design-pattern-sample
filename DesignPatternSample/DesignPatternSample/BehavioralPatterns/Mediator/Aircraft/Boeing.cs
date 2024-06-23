namespace DesignPatternSample.BehavioralPatterns.Mediator;

public class Boeing : Aircraft
{
    public Boeing(IAirTrafficMediator airTrafficMediator, string name) : base(airTrafficMediator, name)
    {
    }

    public override void RequestLanding()
    {
        base._airTrafficMediator.RequestLanding(this);
    }

    public override void RequestTakeoff()
    {
        base._airTrafficMediator.RequestTakeoff(this);
    }
}