namespace DesignPatternSample.Factory.PaymentFactory;

public abstract class SuperPaymentFactory
{
    protected abstract IPayment CreatePaymentMethod();

    public void MakePayment(decimal amount)
    {
        var payment = this.CreatePaymentMethod();
        payment.ProcessPayment(amount);
    }
}