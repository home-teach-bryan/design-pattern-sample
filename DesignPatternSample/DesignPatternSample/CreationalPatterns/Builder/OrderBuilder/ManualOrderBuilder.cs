using DesignPatternSample.CreationalPatterns.Builder;

namespace DesignPatternSample.CreationalPatterns.Builder.OrderBuilder;

public class ManualOrderBuilder : IOrderBuilder
{
    private Order _order;
    public ManualOrderBuilder()
    {
        _order = new Order();
    }

    public void SetOrderId(string id)
    {
        _order.OrderId = $"ManualOrder_ID:{id}";
    }

    public void SetProductName(string name)
    {
        _order.ProductName = $"ManualOrder_Name:{name}";
    }

    public void SetQuantity(int quantity)
    {
        _order.Quantity = quantity;
    }

    public void SetShipAddress(string address)
    {
        _order.ShipAddress = $"ManualOrder_Address:{address}";
    }

    public void SetReceiverName(string receiverName)
    {
        _order.ReceiverName = $"ManualOrder_ReceiverName:{receiverName}";
    }

    public Order GetOrder()
    {
        return _order;
    }

    public void Reset()
    {
        _order = new Order();
    }
}