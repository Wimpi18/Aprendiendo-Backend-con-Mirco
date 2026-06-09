public class CouponService : INotificationHandler
{
    public void Handle(UserRegisteredEvent eventData)
    {
        Console.WriteLine($"🎟️ Coupon issued for {eventData.Username}");
    }
}
