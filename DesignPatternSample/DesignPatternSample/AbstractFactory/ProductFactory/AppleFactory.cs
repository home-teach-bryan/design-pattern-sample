using DesignPatternSample.AbstractFactory.Product;

namespace DesignPatternSample.AbstractFactory.ProductFactory;

public class AppleFactory : IProductFactory
{
    public Electronic GenerateElectronic()
    {
        return new Mac("Mac");
    }

    public MobilePhone GenerateMobilePhone()
    {
        return new IPhone("IPhone");
    }
}