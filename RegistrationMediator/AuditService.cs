public class AuditService : INotificationHandler
{
    public void Handle(UserRegisteredEvent eventData)
    {
        Console.WriteLine($"💾 Audit logged for {eventData.Username}");
    }
}
