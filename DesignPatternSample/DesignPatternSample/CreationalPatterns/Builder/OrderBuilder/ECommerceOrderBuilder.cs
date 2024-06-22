using DesignPatternSample.CreationalPatterns.Builder;

namespace DesignPatternSample.CreationalPatterns.Builder.OrderBuilder;

public class ECommerceOrderBuilder : IOrderBuilder
{
    private Order _order;

    public ECommerceOrderBuilder()
    {
        _order = new Order();
    }
    public void SetOrderId(string id)
    {
        _order.OrderId = $"ECommerceOrder_Id:{id}";
    }

    public void SetProductName(string name)
    {
        _order.ProductName = $"ECommerceOrder_Name:{name}";
    }

    public void SetQuantity(int quantity)
    {
        _order.Quantity = quantity;
    }

    public void SetShipAddress(string address)
    {
        _order.ShipAddress = $"ECommerceOrder_Address:{address}";
    }

    public void SetReceiverName(string receiverName)
    {
        _order.ReceiverName = $"ECommerceOrder_ReceiverName:{receiverName}";
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