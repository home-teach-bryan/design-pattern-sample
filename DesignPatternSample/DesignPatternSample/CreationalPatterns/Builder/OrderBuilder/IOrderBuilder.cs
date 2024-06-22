using DesignPatternSample.CreationalPatterns.Builder;

namespace DesignPatternSample.CreationalPatterns.Builder.OrderBuilder;

public interface IOrderBuilder
{
    void SetOrderId(string id);

    void SetProductName(string name);

    void SetQuantity(int quantity);

    void SetShipAddress(string address);

    void SetReceiverName(string receiverName);

    Order GetOrder();

    void Reset();
}