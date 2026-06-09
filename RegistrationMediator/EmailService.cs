public class EmailService : INotificationHandler
{
    public void Handle(UserRegisteredEvent eventData)
    {
        Console.WriteLine($"📧 Email sent to {eventData.Username}");
    }
}
