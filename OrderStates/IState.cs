public interface IState
{
    void ProcesarPago(Order order);
    void Cancelar(Order order);
}
