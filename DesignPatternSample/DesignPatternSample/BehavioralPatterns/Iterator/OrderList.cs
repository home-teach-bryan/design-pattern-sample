using System.Collections;

namespace DesignPatternSample.BehavioralPatterns.Iterator;

public class OrderList : IEnumerable<Order>
{
    private Order[] _orders;
    private int _index = -1;

    public OrderList(Order[] orders)
    {
        this._orders = orders;
    }

    public IEnumerator<Order> GetEnumerator()
    {
        for (var index = 0; index < _orders.Length; index++)
        {
            yield return _orders[index];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}