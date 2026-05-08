public class ServerConfigFactory
{
    Dictionary<string, ServerConfiguration> ServerConfigurations = [];

    public ServerConfiguration GetConfiguration(string os, string region)
    {
        string key = $"{os}+{region}";
        if (ServerConfigurations.ContainsKey((key)))
            return ServerConfigurations[key];
        else
            ServerConfigurations.Add(key, new ServerConfiguration(os, region));

        return ServerConfigurations[key];
    }
}
