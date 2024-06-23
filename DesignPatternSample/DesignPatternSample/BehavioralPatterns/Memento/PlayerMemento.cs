namespace DesignPatternSample.BehavioralPatterns.Memento;

public class PlayerMemento
{
    public int Level { get; private set; }

    public int Money { get; private set; }
    
    public PlayerMemento(int level, int money)
    {
        this.Level = level;
        this.Money = money;
    }
}