public class OrderManager : ISubject
{
    private readonly List<IObserver> _observers = new();
    private Order? _lastOrder;

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (IObserver observer in _observers)
        {
            observer.Update(_lastOrder);
        }
    }

    public void CreateOrder(Order order)
    {
        _lastOrder = order;
        Console.WriteLine($"[OrderManager]: Pedido #{order.Id} creado.");

        // Tras crear el pedido, debemos avisar a los interesados
        Notify();
    }
}
