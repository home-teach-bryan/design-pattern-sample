using System.Text;

namespace DesignPatternSample.BehavioralPatterns.Command;

public class TextEditor
{
    private StringBuilder _text = new StringBuilder();

    public void AddText(string text)
    {
        _text.Append(text);
        Console.WriteLine($"Current text: {_text}");
    }

    public void RemoveText(int length)
    {
        if (length > _text.Length)
        {
            length = _text.Length;
        }

        _text.Remove(_text.Length - length, length);
        Console.WriteLine($"Current text: {_text}");
    }
}