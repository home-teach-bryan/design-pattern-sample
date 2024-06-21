namespace DesignPatternSample.Builder;

public class ManualOrderBuilder : IOrderBuilder
{
    private Order _order;
    public ManualOrderBuilder()
    {
        this._order = new Order();
    }
    
    public void SetOrderId(string id)
    {
        this._order.OrderId = $"ManualOrder_ID:{id}";
    }

    public void SetProductName(string name)
    {
        this._order.ProductName = $"ManualOrder_Name:{name}";
    }

    public void SetQuantity(int quantity)
    {
        this._order.Quantity = quantity;
    }

    public void SetShipAddress(string address)
    {
        this._order.ShipAddress = $"ManualOrder_Address:{address}";
    }

    public void SetReceiverName(string receiverName)
    {
        this._order.ReceiverName =$"ManualOrder_ReceiverName:{receiverName}";
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