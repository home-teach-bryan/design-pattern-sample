namespace DesignPatternSample.StructuralPatterns.Decorator.MessageDecorator;

public abstract class MessageDecorator : IMessage
{
    private readonly IMessage _message;

    protected MessageDecorator(IMessage message)
    {
        _message = message;
    }
    
    public virtual string GetContent()
    {
        return _message.GetContent();
    }
}