public class InventoryService
{
    public void Update(object? sender, Order order)
    {
        if (order is null)
            return;

        Console.WriteLine($"[InventoryService]: Reduciendo stock para el pedido #{order.Id}.");
        foreach (var item in order.Items)
        {
            Console.WriteLine($" -> Producto ID: {item.ProductId} x {item.Quantity} unidades.");
        }
    }
}
