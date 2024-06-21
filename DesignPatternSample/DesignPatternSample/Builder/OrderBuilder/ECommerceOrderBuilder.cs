namespace DesignPatternSample.Builder;

public class ECommerceOrderBuilder : IOrderBuilder
{
    private Order _order;

    public ECommerceOrderBuilder()
    {
        this._order = new Order();
    }
    public void SetOrderId(string id)
    {
        this._order.OrderId = $"ECommerceOrder_Id:{id}";
    }

    public void SetProductName(string name)
    {
        this._order.ProductName = $"ECommerceOrder_Name:{name}";
    }

    public void SetQuantity(int quantity)
    {
        this._order.Quantity = quantity;
    }

    public void SetShipAddress(string address)
    {
        this._order.ShipAddress = $"ECommerceOrder_Address:{address}";
    }

    public void SetReceiverName(string receiverName)
    {
        this._order.ReceiverName = $"ECommerceOrder_ReceiverName:{receiverName}";
    }

    public Order GetOrder()
    {
        return this._order;
    }

    public void Reset()
    {
        this._order = new Order();
    }
}