namespace DesignPatternSample.BehavioralPatterns.Strategy;

public class NoDiscountStrategy : IDiscountStrategy
{
    public decimal GetDiscountedPrice(decimal price)
    {
        return price;
    }
}