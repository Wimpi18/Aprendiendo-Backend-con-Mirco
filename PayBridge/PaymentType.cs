public abstract class PaymentType
{
    protected IPaymentGateway paymentGateway;

    public PaymentType(IPaymentGateway paymentGateway)
    {
        this.paymentGateway = paymentGateway;
    }

    public abstract string PayMoney(decimal money);
}
