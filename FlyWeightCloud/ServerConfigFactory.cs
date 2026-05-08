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

    public class ServerConfiguration
    {
        public string OS { get; }
        public string Region { get; }

        internal ServerConfiguration(string os, string region)
        {
            OS = os;
            Region = region;
            Console.WriteLine(
                $"[SISTEMA] Creando nueva configuración física para: {os} en {region}"
            );
        }

        public void Display(string ipAddress, double cpuUsage)
        {
            Console.WriteLine(
                $"Server [{ipAddress}] - OS: {OS}, Region: {Region}, CPU: {cpuUsage}%"
            );
        }
    }
}
