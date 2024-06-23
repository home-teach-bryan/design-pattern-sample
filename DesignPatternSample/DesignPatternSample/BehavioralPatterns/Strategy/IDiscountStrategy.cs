namespace DesignPatternSample.BehavioralPatterns.Strategy;

public interface IDiscountStrategy
{
    decimal GetDiscountedPrice(decimal price);
}