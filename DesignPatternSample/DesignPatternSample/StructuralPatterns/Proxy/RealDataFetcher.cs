namespace DesignPatternSample.StructuralPatterns.Proxy;

public class RealDataFetcher : IDataFetcher
{
    public string FetchData(string query)
    { 
        Console.WriteLine("Fetching data from remote service...");
        return $"Data for {query}";
    }
}