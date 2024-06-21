namespace DesignPatternSample.Builder;

public class Order
{
    public string OrderId { get; set; }
    
    public string ProductName { get; set; }
    
    public int Quantity { get; set; }
    
    public string ShipAddress { get; set; }
    
    public string ReceiverName { get; set; }
}