public class SubscriptionPayment : PaymentType
{
    public SubscriptionPayment(IPaymentGateway paymentGateway)
        : base(paymentGateway) { }

    public override string PayMoney(decimal money)
    {
        return paymentGateway.CollectMoney(money + money * 0.01m);
    }
}
