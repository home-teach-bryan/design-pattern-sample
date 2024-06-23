namespace DesignPatternSample.BehavioralPatterns.Mediator;

public class Airbus : Aircraft
{
    public Airbus(IAirTrafficMediator airTrafficMediator, string name) : base(airTrafficMediator, name)
    {
    }

    public override void RequestLanding()
    {
        base._airTrafficMediator.RequestLanding(this);
    }

    public override void RequestTakeoff()
    {
        base._airTrafficMediator.RequestLanding(this);
    }
}