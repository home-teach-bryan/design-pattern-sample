using DesignPatternSample.CreationalPatterns.FactoryMethod.PaymentMethod;

namespace DesignPatternSample.CreationalPatterns.FactoryMethod.PaymentFactory;

public class CashPaymentFactory : SuperPaymentFactory
{
    protected override IPayment CreatePaymentMethod()
    {
        return new CashPayment();
    }
}