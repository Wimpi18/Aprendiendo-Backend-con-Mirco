public class OrderService
{
    // 1. Declaramos una variable privada de solo lectura para la interfaz
    private readonly INotifier _notifier;

    // 2. Pedimos la interfaz en el constructor
    public OrderService(INotifier notifier)
    {
        _notifier = notifier;
    }

    public void CompleteOrder(int orderId)
    {
        // Lógica de negocio (guardar en base de datos, cobrar tarjeta, etc.)
        Console.WriteLine($"Procesando orden {orderId}...");

        // 3. Usamos el notificador sin saber qué hay detrás
        _notifier.Send($"Tu orden {orderId} ha sido procesada exitosamente.");
    }
}
