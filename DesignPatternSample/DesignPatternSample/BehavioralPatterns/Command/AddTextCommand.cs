namespace DesignPatternSample.BehavioralPatterns.Command;

public class AddTextCommand : ICommand
{
    private TextEditor _editor;
    private string _text;

    public AddTextCommand(TextEditor editor, string text)
    {
        _editor = editor;
        _text = text;
    }

    public void Execute()
    {
        _editor.AddText(_text);
    }

    public void Undo()
    {
        _editor.RemoveText(_text.Length);
    }
}