namespace DesignPatternSample.BehavioralPatterns.Command;

public class RemoveTextCommand : ICommand
{
    private TextEditor _editor;
    private int _length;

    public RemoveTextCommand(TextEditor editor, int length)
    {
        _editor = editor;
        _length = length;
    }

    public void Execute()
    {
        _editor.RemoveText(_length);
    }

    public void Undo()
    {
        Console.WriteLine("Undo operation not supported for RemoveTextCommand.");
    }
}