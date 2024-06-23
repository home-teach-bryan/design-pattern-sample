namespace DesignPatternSample.BehavioralPatterns.Strategy;

public class ClearanceDiscountStrategy : IDiscountStrategy
{
    public decimal GetDiscountedPrice(decimal price)
    {
        return price * 0.5m;
    }
}