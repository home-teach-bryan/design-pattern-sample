namespace DesignPatternSample.Prototype;

public class Word
{
    public string Name { get; private set; }

    public string Title { get; private set; }

    public Word(string name, string title)
    {
        this.Name = name;
        this.Title = title;
    }

    public Word ShallowCopy()
    {
        return (Word)this.MemberwiseClone();
    }

    public void SetName(string name)
    {
        this.Name = name;
    }
}