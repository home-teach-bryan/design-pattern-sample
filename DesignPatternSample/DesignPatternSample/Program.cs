using System.Threading.Channels;

namespace DesignPatternSample;

class Program
{
    static void Main(string[] args)
    {
        #region 單例模式(Singleton)

        var firstSingleton = Singleton.Singleton.Instance;
        Console.WriteLine(firstSingleton.GetId());
        var secondSingleton = Singleton.Singleton.Instance;
        Console.WriteLine(secondSingleton.GetId());

        #endregion
        
        
        
        Console.Read();
    }
}