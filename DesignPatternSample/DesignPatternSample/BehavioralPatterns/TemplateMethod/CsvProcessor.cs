namespace DesignPatternSample.BehavioralPatterns.TemplateMethod;

public class CsvProcessor : DataProcessor
{
    protected override void ReadData()
    {
        Console.Write("CSV ReadData");
    }

    protected override void Process()
    {
        Console.Write("CSV Process");
    }

    protected override void SaveData()
    {
        Console.WriteLine("CSV SaveData");
    }
}