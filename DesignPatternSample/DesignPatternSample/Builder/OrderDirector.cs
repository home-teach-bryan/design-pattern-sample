namespace DesignPatternSample.Builder;

public class OrderDirector
{
    private readonly IOrderBuilder _orderBuilder;

    public OrderDirector(IOrderBuilder orderBuilder)
    {
        _orderBuilder = orderBuilder;
    }

    public Order Build()
    {
        _orderBuilder.SetOrderId("1");
        _orderBuilder.SetQuantity(1);
        _orderBuilder.SetReceiverName("Andy");
        _orderBuilder.SetProductName("3C");
        _orderBuilder.SetShipAddress("Abc city");
        var order = _orderBuilder.GetOrder();
        _orderBuilder.Reset();
        return order;

    }
}