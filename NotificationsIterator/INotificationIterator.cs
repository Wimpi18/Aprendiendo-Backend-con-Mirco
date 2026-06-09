public interface INotificationIterator
{
    public Notification? GetNext();

    public Boolean HasMore();
}
