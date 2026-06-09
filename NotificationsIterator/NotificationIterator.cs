public class NotificationIterator : INotificationIterator
{
    private readonly List<Notification> _notifications;
    private int _position = 0;

    public NotificationIterator(List<Notification> notifications)
    {
        _notifications = notifications;
    }

    public Notification? GetNext()
    {
        Notification? notification = null;
        if (HasMore())
        {
            notification = _notifications[_position];
            _position++;
        }
        return notification;
    }

    public bool HasMore()
    {
        return _position < _notifications.Count() ? true : false;
    }
}
