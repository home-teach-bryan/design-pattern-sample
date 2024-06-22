namespace DesignPatternSample.StructuralPatterns.Adapter;

public class JapanPowerAdapter : IJapanPowerAdapter
{
    private IUsaPowerPlug _usaPowerPlug;
    public JapanPowerAdapter(IUsaPowerPlug usaPowerPlug)
    {
        _usaPowerPlug = usaPowerPlug;
    }
    public void PlugInOutlet()
    {
        Console.WriteLine("Using adapter to plug in to Japan outlet.");
        _usaPowerPlug.PlugInOutlet();
    }
}