using DesignPatternSample.BehavioralPatterns.ChainOfResponsiblity;
using DesignPatternSample.BehavioralPatterns.Command;
using DesignPatternSample.BehavioralPatterns.Iterator;
using DesignPatternSample.BehavioralPatterns.Mediator;
using DesignPatternSample.BehavioralPatterns.Memento;
using DesignPatternSample.BehavioralPatterns.Observer;
using DesignPatternSample.BehavioralPatterns.State;
using DesignPatternSample.BehavioralPatterns.Strategy;
using DesignPatternSample.BehavioralPatterns.TemplateMethod;
using DesignPatternSample.BehavioralPatterns.Visitor;
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
using Order = DesignPatternSample.BehavioralPatterns.Iterator.Order;

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

        #region 行為型模式

        #region 策略模式 (Strategy Pattern)

        var noDiscount = new NoDiscountStrategy();
        var shoppingCart = new ShoppingCart();
        shoppingCart.SetDiscountStrategy(noDiscount);
        Console.WriteLine($"NoDiscount Price:{shoppingCart.GetCalculatePrice(100m)}");

        var seasonDiscount = new SeasonDiscountStrategy();
        shoppingCart.SetDiscountStrategy(seasonDiscount);
        Console.WriteLine($"SeasonDiscount Price:{shoppingCart.GetCalculatePrice(100m)}");

        var clearanceDiscount = new ClearanceDiscountStrategy();
        shoppingCart.SetDiscountStrategy(clearanceDiscount);
        Console.WriteLine($"ClearanceDiscount Price:{shoppingCart.GetCalculatePrice(100m)}");
        
        #endregion

        #region 模板方法(Template Method Pattern)

        DataProcessor csvProcessor = new CsvProcessor();
        csvProcessor.ProcessData();
        
        DataProcessor jsonProcessor = new JsonProcessor();
        jsonProcessor.ProcessData();
        
        DataProcessor xmlProcessor = new XmlProcessor();
        xmlProcessor.ProcessData();
        
        #endregion

        #region 命令模式(Command Pattern)

        TextEditor editor = new TextEditor();
        CommandInvoker invoker = new CommandInvoker();

        ICommand addText1 = new AddTextCommand(editor, "Hello, ");
        ICommand removeText1 = new RemoveTextCommand(editor, 2);
        invoker.ExecuteCommand(addText1);
        invoker.ExecuteCommand(removeText1);
        
        invoker.UndoCommand();
        invoker.UndoCommand();

        #endregion

        #region 迭代器模式(Iterator Pattern)

        Order[] orders = new Order[]
        {
            new Order { ID = "1", Name = "Test1" },
            new Order { ID = "2", Name = "Test2" }
        };
        var orderList = new OrderList(orders);

        foreach (var order in orderList)
        {
            Console.WriteLine($"Order:{order.ID}, {order.Name}");
        }
        #endregion
        
        #region 中介者模式(Mediator Pattern) 
        
        IAirTrafficMediator airTrafficMediator = new AirTrafficControl();
        Aircraft boeing747 = new Boeing(airTrafficMediator, "Boeing 747");
        boeing747.RequestTakeoff();
        boeing747.RequestLanding();

        Aircraft airBus = new Airbus(airTrafficMediator, "AirBus");
        airBus.RequestTakeoff();
        airBus.RequestLanding();
        
        #endregion

        #region 備忘錄模式(Memento Pattern)

        var gamePlayer = new GamePlayer(1, 100);
        gamePlayer.StateDisplay();
        var memento = gamePlayer.CreateMemento();
        var careTaker = new PlayerStateCaretaker
        {
            Memento = memento
        };
        gamePlayer.Die();
        gamePlayer.StateDisplay();
        gamePlayer.RecoveryMemento(careTaker.Memento);
        gamePlayer.StateDisplay();
        
        #endregion

        #region 觀察者模式(Observer Pattern)

        IObserver observer1 = new Subscriber("Test1");
        IObserver observer2 = new Subscriber("Test2");
        IObserver observer3 = new Subscriber("Test3");
        
        ISubject newPublisher = new NewsPublisher();
        newPublisher.Attach(observer1);
        newPublisher.Attach(observer2);
        newPublisher.Attach(observer3);
        newPublisher.Notify("First News");
        
        newPublisher.Detach(observer1);
        newPublisher.Notify("Second News");
        
        #endregion
        
        #region 狀態模式(State Pattern)

        var elevator = new Elevator();
        IState openState = new OpenState();
        IState closeState = new CloseState();
        IState runState = new RunState();
        elevator.Run();
        elevator.ChangeState(openState);
        elevator.Open();
        elevator.ChangeState(closeState);
        elevator.Close();
        elevator.ChangeState(runState);
        elevator.Run();
        
        #endregion

        #region 責任鏈模式(ChainOfResponsiblity)

        Leader teamLeader = new TeamLeader("部門主管");
        Leader director = new Director("部門經理");
        Leader generalManager = new GeneralManager("總經理");
        
        teamLeader.SetNext(director);
        director.SetNext(generalManager);
        teamLeader.HandleRequest(5);
        
        #endregion

        #region 訪問者模式(Visitor Pattern)

        Payroll payroll = new Payroll();
        payroll.Attach(new FullTimeEmployee("Alice", 5000));
        payroll.Attach(new PartTimeEmployee("Bob", 20, 100));

        IVisitor salaryCalculator = new SalaryCalculator();
        payroll.Accept(salaryCalculator);

        #endregion
        
        #endregion
        
        Console.Read();
    }
}