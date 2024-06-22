namespace DesignPatternSample.StructuralPatterns.Flyweight;

public class MessageFlyweight : IFlyweight
{
    private string sharedText;

    public MessageFlyweight(string text)
    {
        this.sharedText = text;
    }

    public void Display(string text)
    {
        Console.WriteLine($"Displaying shared text: {sharedText}, additional text: {text}");
    }
}