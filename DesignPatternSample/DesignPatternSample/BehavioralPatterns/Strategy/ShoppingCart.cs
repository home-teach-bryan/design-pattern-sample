namespace DesignPatternSample.BehavioralPatterns.Strategy;

public class ShoppingCart
{
    private IDiscountStrategy _strategy;


    public void SetDiscountStrategy(IDiscountStrategy strategy)
    {
        this._strategy = strategy;
    }

    public decimal GetCalculatePrice(decimal price)
    {
        return _strategy.GetDiscountedPrice(price);
    }
}