namespace DesignPatternSample.Factory.PaymentFactory;

public class CreditCardPaymentFactory : SuperPaymentFactory
{
    protected override IPayment CreatePaymentMethod()
    {
        return new CreditCardPayment();
    }
}