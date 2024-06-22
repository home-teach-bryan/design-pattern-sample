namespace DesignPatternSample.CreationalPatterns.FactoryMethod.PaymentMethod;

public class CashPayment : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Use Cash Payment to Pay:{amount}");
    }
}