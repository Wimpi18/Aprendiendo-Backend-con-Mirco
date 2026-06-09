public class NotificationMediator : IMediator<UserRegisteredEvent>
{
    IEnumerable<INotificationHandler> _services;

    public NotificationMediator(IEnumerable<INotificationHandler> services)
    {
        _services = services;
    }

    public void Notify(UserRegisteredEvent eventData)
    {
        foreach (var service in _services)
        {
            service.Handle(eventData);
        }
    }
}
