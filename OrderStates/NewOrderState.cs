public class NewOrderState : OrderState
{
    public override void ProcesarPago(Order order)
    {
        order.TransitionTo(new PaidOrderState());
    }
}
