using DesignPatternSample.CreationalPatterns.FactoryMethod.PaymentMethod;

namespace DesignPatternSample.CreationalPatterns.FactoryMethod.PaymentFactory;

public class CreditCardPaymentFactory : SuperPaymentFactory
{
    protected override IPayment CreatePaymentMethod()
    {
        return new CreditCardPayment();
    }
}