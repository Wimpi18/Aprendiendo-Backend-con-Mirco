public class PayPal : IPaymentGateway
{
    public PayPal() { }

    public string CollectMoney(decimal money)
    {
        return $"PayPal a tu servicio, el monto cobrado fue de {money}$";
    }
}
