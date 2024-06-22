namespace DesignPatternSample.StructuralPatterns.Decorator.MessageDecorator;

public class EncryptedMessage : MessageDecorator
{
    public EncryptedMessage(IMessage message) : base(message)
    {
    }

    public override string GetContent()
    {
        var encrypted = this.Encrypted();
        return $"{encrypted}: {base.GetContent()}";
    } 
    private string Encrypted()
    {
        // some login

        return "Encrypted Message";
    }
}