public class NotificationService : IObserver
{
    public void Update(Order? order)
    {
        if (order is null)
            return;

        Console.WriteLine(
            $"[NotificationService]: Enviando correo de confirmación a {order.CustomerEmail}."
        );
        foreach (var item in order.Items)
        {
            Console.WriteLine($" -> Producto ID: {item.ProductId} x {item.Quantity} unidades.");
        }
    }
}
