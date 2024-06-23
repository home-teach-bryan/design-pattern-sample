namespace DesignPatternSample.BehavioralPatterns.Observer;

public class NewsPublisher : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();
    
    public void Attach(IObserver observer)
    {
        this._observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        this._observers.Remove(observer);
    }

    public void Notify(string news)
    {
        foreach (var observer in this._observers)
        {
            observer.Update(news);
        }
    }
}