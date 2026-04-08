public class Stripe : IPaymentGateway
{
    public Stripe() { }

    public string CollectMoney(decimal money)
    {
        return $"Gracias por confiar en Stripe, el monto cobrado fue de {money}$";
    }
}
