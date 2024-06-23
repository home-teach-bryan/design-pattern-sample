namespace DesignPatternSample.BehavioralPatterns.Mediator;

public interface IAirTrafficMediator
{
    void RequestLanding(Aircraft aircraft);
    void RequestTakeoff(Aircraft aircraft);
}