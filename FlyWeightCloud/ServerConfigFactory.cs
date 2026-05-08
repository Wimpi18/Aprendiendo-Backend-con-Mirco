using System.Collections.Concurrent;

public class ServerConfigFactory
{
    private readonly ConcurrentDictionary<string, ServerConfiguration> ServerConfigurations = [];

    public ServerConfiguration GetConfiguration(string os, string region)
    {
        string key = $"{os}+{region}";
        ValueTuple<string, string> value = (os, region);
        return ServerConfigurations.GetOrAdd(
            key,
            (key, arg) => new ServerConfiguration(arg.Item1, arg.Item2),
            value
        );
    }
}
