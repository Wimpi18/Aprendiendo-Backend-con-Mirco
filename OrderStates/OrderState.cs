public abstract class OrderState : IState
{
    public virtual void ProcesarPago(Order order) =>
        throw new InvalidOperationException(
            $"No se puede procesar el pago en el estado {this.GetType().Name}"
        );

    public virtual void Cancelar(Order order) =>
        throw new InvalidOperationException(
            $"No se puede cancelar el pedido en el estado {this.GetType().Name}"
        );

    public virtual void Despachar(Order order) =>
        throw new InvalidOperationException(
            $"No se puede despachar en el estado {this.GetType().Name}"
        );
}
