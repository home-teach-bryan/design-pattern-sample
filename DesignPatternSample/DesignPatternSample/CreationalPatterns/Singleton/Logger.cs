using System.Runtime.CompilerServices;

namespace DesignPatternSample.CreationalPatterns.Singleton;

public sealed class Logger
{
    private static Logger _logger = new Logger();

    private readonly int _id;

    private Logger()
    {
        _id = Guid.NewGuid().GetHashCode();
    }

    public static Logger Instance
    {
        get { return _logger; }
    }

    public int GetId()
    {
        return _id;
    }
}