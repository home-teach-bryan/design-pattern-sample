namespace DesignPatternSample.StructuralPatterns.Decorator;

public class SimpleMessage : IMessage
{
    private readonly string _message;

    public SimpleMessage(string message)
    {
        _message = message;
    }

    public string GetContent()
    {
        return this._message;
    }
}