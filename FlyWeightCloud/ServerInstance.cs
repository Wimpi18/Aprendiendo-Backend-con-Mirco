public class ServerInstance
{
    private readonly string _ipAddress;
    private readonly ServerConfiguration _config;

    public ServerInstance(string ipAddress, ServerConfiguration config)
    {
        _ipAddress = ipAddress;
        _config = config;
    }

    public void ShowStatus(double cpuUsage)
    {
        _config.Display(_ipAddress, cpuUsage);
    }
}
