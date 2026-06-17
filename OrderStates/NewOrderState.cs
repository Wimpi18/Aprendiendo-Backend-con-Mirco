public class NewOrderState : IState
{
    public void Cancelar(Order order)
    {
        throw new Exception("No se puede cancelar el pedido");
    }

    public void ProcesarPago(Order order)
    {
        order.TransitionTo(new PaidOrderState());
    }
}
