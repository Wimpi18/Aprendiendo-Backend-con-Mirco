public class CloudSmsAdapter : INotifier
{
    CloudSmsService cloudSmsService;
    String recipent;

    public CloudSmsAdapter(CloudSmsService cloudSmsService, String recipent)
    {
        this.cloudSmsService = cloudSmsService;
        this.recipent = recipent;
    }

    public void Send(string message)
    {
        cloudSmsService.PushText(recipent, message);
    }
}
