namespace DesignPatternSample.StructuralPatterns.Decorator.MessageDecorator;

public class CompressMessage : MessageDecorator
{
    public CompressMessage(IMessage message) : base(message)
    {
    }

    public override string GetContent()
    {
        var compress = this.Compress();
        return $"{compress}: return base.GetContent()";
    }

    private string Compress()
    {
        // some logic
        return "Message Compressed";
    }
    
}