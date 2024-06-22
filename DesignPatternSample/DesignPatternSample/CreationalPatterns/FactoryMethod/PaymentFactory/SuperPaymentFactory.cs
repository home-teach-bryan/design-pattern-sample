using DesignPatternSample.CreationalPatterns.FactoryMethod.PaymentMethod;

namespace DesignPatternSample.CreationalPatterns.FactoryMethod.PaymentFactory;

public abstract class SuperPaymentFactory
{
    protected abstract IPayment CreatePaymentMethod();

    public void MakePayment(decimal amount)
    {
        var payment = CreatePaymentMethod();
        payment.ProcessPayment(amount);
    }
}