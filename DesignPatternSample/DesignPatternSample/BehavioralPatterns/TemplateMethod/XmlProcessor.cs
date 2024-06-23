namespace DesignPatternSample.BehavioralPatterns.TemplateMethod;

public class XmlProcessor : DataProcessor
{
    protected override void ReadData()
    {
        Console.Write("XML ReadData");
    }

    protected override void Process()
    {
        Console.Write("XML Process");
    }

    protected override void SaveData()
    {
        Console.Write("XML SaveData");
    }
}