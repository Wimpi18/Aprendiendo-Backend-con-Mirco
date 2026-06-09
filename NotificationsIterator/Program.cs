NotificationBatch batch = new NotificationBatch();
batch.AddNotification(new Notification { Message = "Welcome!", Channel = "Email" });
batch.AddNotification(new Notification { Message = "Security Code", Channel = "SMS" });

INotificationIterator iterator = batch.GetIterator();

while (iterator.HasMore())
{
    Notification? notification = iterator.GetNext();
    Console.WriteLine($"{notification?.Message}, {notification?.Channel}");
}
