namespace DesignPatternSample.BehavioralPatterns.TemplateMethod;

public class JsonProcessor : DataProcessor
{
    protected override void ReadData()
    {
        Console.WriteLine("Json ReadData");
    }

    protected override void Process()
    {
        Console.WriteLine("Json Process");
    }

    protected override void SaveData()
    {
        Console.WriteLine("Json SaveData");
    }
}