using System.Collections;

public class NotificationBatch : INotificationCollection
{
    private List<Notification> _notifications = new List<Notification>();

    public void AddNotification(Notification notification)
    {
        _notifications.Add(notification);
    }

    public INotificationIterator GetIterator()
    {
        return new NotificationIterator(_notifications);
    }
}
