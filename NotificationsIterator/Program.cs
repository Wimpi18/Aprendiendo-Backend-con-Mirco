NotificationBatch batch = new NotificationBatch();
batch.AddNotification(new Notification { Message = "Microservice Started", Channel = "Slack" });
batch.AddNotification(new Notification { Message = "App Error Logged", Channel = "Email" });

IEnumerator<Notification> notification = batch.GetEnumerator();
while (notification.MoveNext())
{
    Console.WriteLine($"{notification.Current.Message}, {notification.Current.Channel}");
}
