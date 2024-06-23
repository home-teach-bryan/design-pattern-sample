namespace DesignPatternSample.BehavioralPatterns.Observer;

public class Subscriber : IObserver
{
    private string _name;

    public Subscriber(string name)
    {
        this._name = name;
    }
    
    public void Update(string news)
    {
        Console.WriteLine($"{_name} received news: {news}");
    }
}