public class OneTimePayment : PaymentType
{
    public OneTimePayment(IPaymentGateway paymentGateway)
        : base(paymentGateway) { }

    public override string PayMoney(decimal money)
    {
        return paymentGateway.CollectMoney(money);
    }
}
