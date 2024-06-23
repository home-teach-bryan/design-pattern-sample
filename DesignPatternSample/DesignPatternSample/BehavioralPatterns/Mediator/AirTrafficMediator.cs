namespace DesignPatternSample.BehavioralPatterns.Mediator;

public class AirTrafficControl : IAirTrafficMediator
{
    public void RequestLanding(Aircraft aircraft)
    {
        Console.WriteLine($"{aircraft.Name} requests landing clearance.");
    }

    public void RequestTakeoff(Aircraft aircraft)
    {
        Console.WriteLine($"{aircraft.Name} requests takeoff clearance.");
    }
}