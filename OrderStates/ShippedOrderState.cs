public class ShippedOrderState : IState
{
    public void Cancelar(Order order)
    {
        order.TransitionTo(new NewOrderState());
    }

    public void ProcesarPago(Order order)
    {
        throw new Exception("El pedido ya fue pagado con anterioridad");
    }
}
