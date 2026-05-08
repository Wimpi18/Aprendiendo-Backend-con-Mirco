public class ServerInstance
{
    private readonly string _ipAddress;
    private readonly ServerConfigFactory.ServerConfiguration _config;

    public ServerInstance(string ipAddress, ServerConfigFactory.ServerConfiguration config)
    {
        _ipAddress = ipAddress;
        _config = config;
    }

    public void ShowStatus(double cpuUsage)
    {
        _config.Display(_ipAddress, cpuUsage);
    }
}
