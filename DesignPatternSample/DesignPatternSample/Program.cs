using DesignPatternSample.CreationalPatterns.AbstractFactory.ProductFactory;
using DesignPatternSample.CreationalPatterns.Builder;
using DesignPatternSample.CreationalPatterns.Builder.OrderBuilder;
using DesignPatternSample.CreationalPatterns.FactoryMethod.PaymentFactory;
using DesignPatternSample.CreationalPatterns.Prototype;
using DesignPatternSample.CreationalPatterns.Singleton;
using DesignPatternSample.StructuralPatterns.Adapter;
using DesignPatternSample.StructuralPatterns.Bridge;
using DesignPatternSample.StructuralPatterns.Composite;
using DesignPatternSample.StructuralPatterns.Decorator;
using DesignPatternSample.StructuralPatterns.Decorator.MessageDecorator;
using DesignPatternSample.StructuralPatterns.Facade;
using DesignPatternSample.StructuralPatterns.Flyweight;
using DesignPatternSample.StructuralPatterns.Proxy;

namespace DesignPatternSample;

class Program
{
    static void Main(string[] args)
    {
        #region 建立型模式

        #region 單例模式(Singleton)

        var firstSingleton = Logger.Instance;
        Console.WriteLine(firstSingleton.GetId());
        var secondSingleton = Logger.Instance;
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

        #region 建造者模式 (Builder Pattern)

        var manualOrderDirector = new OrderDirector(new ManualOrderBuilder());
        var manualOrder = manualOrderDirector.Build();
        var ecOrderDirector = new OrderDirector(new ECommerceOrderBuilder());
        var ecOrder = ecOrderDirector.Build();
        
        #endregion

        #region 原型模式 (Prototype Pattern)

        var word = new Word("測試", "標題");
        var word2 = word.ShallowCopy();
        word.SetName("測試1");
        Console.WriteLine($"Word_Name:{word.Name}");
        Console.WriteLine($"Word2_Name:{word2.Name}");
        #endregion

        #endregion

        #region 結構型模式

        #region 適配器模式 (Adapter Pattern)

        var usaPowerPlug = new UsaPowerPlug();
        var japanAdapter = new JapanPowerAdapter(usaPowerPlug);
        japanAdapter.PlugInOutlet();

        #endregion

        #region 裝飾器模式 (Decorator Pattern)

        IMessage simpleMessage = new SimpleMessage("SimpleMessage");
        Console.WriteLine($"Orginal:{simpleMessage.GetContent()}");

        IMessage encrypted = new EncryptedMessage(simpleMessage);
        Console.WriteLine($"Encrypted:{encrypted.GetContent()}");

        IMessage compression = new CompressMessage(simpleMessage);
        Console.WriteLine($"Compression:{compression.GetContent()}");
        
        #endregion
        
        #region 代理模式 (Proxy Pattern)

        IDataFetcher dataFetcher = new CachedDataFetcher();
        Console.WriteLine(dataFetcher.FetchData("Data1"));
        Console.WriteLine(dataFetcher.FetchData("Data2"));
        Console.WriteLine(dataFetcher.FetchData("Data3"));
        
        #endregion

        #region 外觀模式 (Facade Pattern)

        DvdPlayer dvdPlayer = new DvdPlayer();
        Projector projector = new Projector();
        SurroundSoundSystem soundSystem = new SurroundSoundSystem();

        HomeTheaterFacade homeTheater = new HomeTheaterFacade(dvdPlayer, projector, soundSystem);

        homeTheater.WatchMovie("Inception");
        Console.WriteLine("Watching Movie...");
        homeTheater.EndMovie();

        #endregion

        #region 橋接模式 (Bridge Pattern)
        
        Television sonyTelevision = new SonyTelevision();
        Television samsungTelevision = new SamsungTelevision();

        RemoteControl remoteControl1 = new TelevisionRemoteControl(sonyTelevision);
        RemoteControl remoteControl2 = new TelevisionRemoteControl(samsungTelevision);

        remoteControl1.TurnOn();
        remoteControl1.SetChannel(5);
        remoteControl1.TurnOff();

        remoteControl2.TurnOn();
        remoteControl2.SetChannel(10);
        remoteControl2.TurnOff();

        #endregion

        #region 組合模式 (Composite Pattern)

        Composite company = new Composite("Company");

        Composite ceoOffice = new Composite("總經理室");
        ceoOffice.Add(new Leaf("總經理"));
        company.Add(ceoOffice);

        Composite engineeringDept = new Composite("工程部");
        engineeringDept.Add(new Leaf("工程師A"));
        engineeringDept.Add(new Leaf("工程師B"));
        company.Add(engineeringDept);

        Composite hrDept = new Composite("人資部");
        hrDept.Add(new Leaf("人資員工A"));
        hrDept.Add(new Leaf("人資員工B"));
        company.Add(hrDept);
        company.Display(0);

        #endregion

        #region 享元模式 (Flyweight Pattern)

        FlyweightFactory factory = new FlyweightFactory();

        IFlyweight flyweight1 = factory.GetFlyweight("Apple");
        flyweight1.Display("is a fruit");

        IFlyweight flyweight2 = factory.GetFlyweight("Apple");
        flyweight2.Display("is a tech company");

        IFlyweight flyweight3 = factory.GetFlyweight("Banana");
        flyweight3.Display("is a fruit");

        Console.WriteLine($"Total flyweights created: {factory.GetTotalFlyweights()}");
        
        #endregion
        
        #endregion
        
        
        
        Console.Read();
    }
}