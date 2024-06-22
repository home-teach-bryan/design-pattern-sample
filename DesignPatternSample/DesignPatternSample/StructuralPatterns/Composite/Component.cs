namespace DesignPatternSample.StructuralPatterns.Composite;

public abstract class Component
{
    protected string _name;
    
    protected Component(string name)
    {
        this._name = name;
    }

    public abstract void Display(int depth);
}