namespace DesignPatternSample.BehavioralPatterns.TemplateMethod;

public abstract class DataProcessor
{
    protected abstract void ReadData();

    protected abstract void Process();

    protected abstract void SaveData();
    
    public void ProcessData()
    {
        ReadData();
        Process();
        SaveData();
    }
}