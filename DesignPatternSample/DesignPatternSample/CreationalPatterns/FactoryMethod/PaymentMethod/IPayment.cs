namespace DesignPatternSample.CreationalPatterns.FactoryMethod.PaymentMethod;

public interface IPayment
{
    void ProcessPayment(decimal amount);
}