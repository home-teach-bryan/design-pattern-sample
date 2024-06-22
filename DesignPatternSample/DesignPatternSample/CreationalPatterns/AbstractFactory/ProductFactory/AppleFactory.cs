using DesignPatternSample.CreationalPatterns.AbstractFactory.Product;

namespace DesignPatternSample.CreationalPatterns.AbstractFactory.ProductFactory;

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