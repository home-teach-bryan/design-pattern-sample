namespace DesignPatternSample.AbstractFactory.Product;

public abstract class Electronic
{
    private readonly string _name;

    protected Electronic(string name)
    {
        _name = name;
    }

    public void DisplayName()
    {
        Console.WriteLine($"It's a Electronic,it name is {this._name}");
    }
}