namespace DesignPatternSample.StructuralPatterns.Flyweight;

public class FlyweightFactory
{
    private Dictionary<string, IFlyweight> flyweights = new Dictionary<string, IFlyweight>();

    public IFlyweight GetFlyweight(string key)
    {
        if (!flyweights.ContainsKey(key))
        {
            flyweights[key] = new MessageFlyweight(key);
        }
        return flyweights[key];
    }

    public int GetTotalFlyweights()
    {
        return flyweights.Count;
    }
}