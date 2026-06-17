public class PaidOrderState : OrderState
{
    public override void Cancelar(Order order)
    {
        order.TransitionTo(new NewOrderState());
    }
}
