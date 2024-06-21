using DesignPatternSample.AbstractFactory.Product;

namespace DesignPatternSample.AbstractFactory.ProductFactory;

public class SamsungFactory : IProductFactory
{
    public Electronic GenerateElectronic()
    {
        return new SamsungTv("SamsungTV");
    }

    public MobilePhone GenerateMobilePhone()
    {
        return new Galaxy("Galaxy");
    }
}