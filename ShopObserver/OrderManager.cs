public class OrderManager
{
    public event EventHandler<Order>? OrderCreated;

    public void CreateOrder(Order order)
    {
        Console.WriteLine($"[OrderManager]: Pedido #{order.Id} creado con Eventos C#.");

        OrderCreated?.Invoke(this, order);
    }
}
