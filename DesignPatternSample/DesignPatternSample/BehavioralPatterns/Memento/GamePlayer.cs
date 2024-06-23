namespace DesignPatternSample.BehavioralPatterns.Memento;

public class GamePlayer
{
    public int Level { get; private set; }

    public int Money { get; private set; }

    public GamePlayer(int level, int money)
    {
        this.Level = level;
        this.Money = money;
    }

    public void StateDisplay()
    {
        Console.WriteLine($"Player:Level:{this.Level}, Money:{this.Money}");
    }

    public void Die()
    {
        this.Level = 0;
        this.Money = 0;
    }

    public PlayerMemento CreateMemento()
    {
        return new PlayerMemento(this.Level, this.Money);
    }

    public void RecoveryMemento(PlayerMemento playerMemento)
    {
        this.Level = playerMemento.Level;
        this.Money = playerMemento.Money;
    }
    
}