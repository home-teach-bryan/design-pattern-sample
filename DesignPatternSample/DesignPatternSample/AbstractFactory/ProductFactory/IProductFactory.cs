using DesignPatternSample.AbstractFactory.Product;

namespace DesignPatternSample.AbstractFactory.ProductFactory;

public interface IProductFactory
{
    Electronic GenerateElectronic();
    MobilePhone GenerateMobilePhone();
}