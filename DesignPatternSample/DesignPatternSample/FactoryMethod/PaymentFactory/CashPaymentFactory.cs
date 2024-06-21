namespace DesignPatternSample.Factory.PaymentFactory;

public class CashPaymentFactory : SuperPaymentFactory
{
    protected override IPayment CreatePaymentMethod()
    {
        return new CashPayment();
    }
}