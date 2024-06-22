namespace DesignPatternSample.CreationalPatterns.Prototype;

public class Word
{
    public string Name { get; private set; }

    public string Title { get; private set; }

    public Word(string name, string title)
    {
        Name = name;
        Title = title;
    }

    public Word ShallowCopy()
    {
        return (Word)MemberwiseClone();
    }

    public void SetName(string name)
    {
        Name = name;
    }
}