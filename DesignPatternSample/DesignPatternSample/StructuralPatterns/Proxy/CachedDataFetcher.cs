namespace DesignPatternSample.StructuralPatterns.Proxy;

public class CachedDataFetcher : IDataFetcher
{
    private RealDataFetcher _realDataFetcher = new RealDataFetcher();
    private Dictionary<string, string> _cache = new Dictionary<string, string>();

    public string FetchData(string query)
    {
        if (_cache.ContainsKey(query))
        {
            Console.WriteLine("Returning cached data...");
            return _cache[query];
        }

        string data = _realDataFetcher.FetchData(query);
        _cache[query] = data;
        return data;
    }
}