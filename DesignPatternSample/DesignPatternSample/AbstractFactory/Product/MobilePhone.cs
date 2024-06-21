namespace DesignPatternSample.AbstractFactory.Product;

public abstract class MobilePhone
{
    private readonly string _name;

    protected MobilePhone(string name)
    {
        _name = name;
    }

    public void DisplayName()
    {
        Console.WriteLine($"It's a MobilePhone, name is {this._name}");
    }
}