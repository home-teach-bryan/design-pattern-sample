using DesignPatternSample.CreationalPatterns.AbstractFactory.Product;

namespace DesignPatternSample.CreationalPatterns.AbstractFactory.ProductFactory;

public interface IProductFactory
{
    Electronic GenerateElectronic();
    MobilePhone GenerateMobilePhone();
}