namespace DesignPatternSample.BehavioralPatterns.Strategy;

public class SeasonDiscountStrategy : IDiscountStrategy
{
    public decimal GetDiscountedPrice(decimal price)
    {
        return price * 0.9m;
    }
}