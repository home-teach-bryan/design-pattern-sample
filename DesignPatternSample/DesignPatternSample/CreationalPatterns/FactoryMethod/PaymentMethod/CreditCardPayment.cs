namespace DesignPatternSample.CreationalPatterns.FactoryMethod.PaymentMethod;

public class CreditCardPayment : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Use CreditCard Payment to Pay:{amount}");
    }
}