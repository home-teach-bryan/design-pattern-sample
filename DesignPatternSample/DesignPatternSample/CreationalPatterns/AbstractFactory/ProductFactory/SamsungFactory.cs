using DesignPatternSample.CreationalPatterns.AbstractFactory.Product;

namespace DesignPatternSample.CreationalPatterns.AbstractFactory.ProductFactory;

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