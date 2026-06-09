using System.Collections;

public class NotificationBatch : IEnumerable<Notification>
{
    private List<Notification> _notifications = new List<Notification>();

    public void AddNotification(Notification notification)
    {
        _notifications.Add(notification);
    }

    public IEnumerator<Notification> GetEnumerator()
    {
        foreach (var notification in _notifications)
        {
            yield return notification;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
