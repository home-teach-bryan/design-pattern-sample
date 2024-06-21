using System.Threading.Channels;
using DesignPatternSample.AbstractFactory.Product;
using DesignPatternSample.AbstractFactory.ProductFactory;
using DesignPatternSample.Builder;
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

        #region 抽象工廠(Abstract Factory Pattern)

        var applyFactory = new AppleFactory();
        var appleElectronic = applyFactory.GenerateElectronic();
        var appleMobilePhone = applyFactory.GenerateMobilePhone();
        appleElectronic.DisplayName();
        appleMobilePhone.DisplayName();

        var samsungFactory = new SamsungFactory();
        var samsungElectronic = samsungFactory.GenerateElectronic();
        var samsungMobilePhone = samsungFactory.GenerateMobilePhone();
        samsungElectronic.DisplayName();
        samsungMobilePhone.DisplayName();

        #endregion

        #region 建造者模式

        var manualOrderDirector = new OrderDirector(new ManualOrderBuilder());
        var manualOrder = manualOrderDirector.Build();
        var ecOrderDirector = new OrderDirector(new ECommerceOrderBuilder());
        var ecOrder = ecOrderDirector.Build();
        

        #endregion
        
        Console.Read();
    }
}