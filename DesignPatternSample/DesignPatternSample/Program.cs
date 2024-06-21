using System.Threading.Channels;
using DesignPatternSample.Factory.PaymentFactory;

namespace DesignPatternSample;

class Program
{
    static void Main(string[] args)
    {
        #region 單例模式(Singleton)

        var firstSingleton = Singleton.Logger.Instance;
        Console.WriteLine(firstSingleton.GetId());
        var secondSingleton = Singleton.Logger.Instance;
        Console.WriteLine(secondSingleton.GetId());

        #endregion

        #region 工廠方法(Factory Method Pattern)

        var cashPayment = new CashPaymentFactory();
        cashPayment.MakePayment(50.00m);

        var creditCardPayment = new CreditCardPaymentFactory();
        creditCardPayment.MakePayment(40.00m);

        #endregion
        
        Console.Read();
    }
}