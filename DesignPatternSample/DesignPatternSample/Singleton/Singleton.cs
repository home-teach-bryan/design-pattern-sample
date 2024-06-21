using System.Runtime.CompilerServices;

namespace DesignPatternSample.Singleton;

public sealed class Singleton
{
    private static Singleton _singleton = new Singleton();

    private readonly int _id;

    private Singleton()
    {
        this._id = Guid.NewGuid().GetHashCode();
    }

    public static Singleton Instance
    {
        get { return _singleton; }
    }

    public int GetId()
    {
        return this._id;
    }
}