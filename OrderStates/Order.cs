public class Order
{
    private ushort _amount { get; set; }
    private decimal _price { get; set; }

    private IState _state = new NewOrderState();

    public void TransitionTo(IState state)
    {
        _state = state;
    }

    public void ProcesarPago()
    {
        _state.ProcesarPago(this);
    }

    public void Cancelar()
    {
        _state.Cancelar(this);
    }
}
