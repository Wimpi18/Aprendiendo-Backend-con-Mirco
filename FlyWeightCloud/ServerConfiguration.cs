public class ServerConfiguration
{
    public string OS { get; }
    public string Region { get; }

    public ServerConfiguration(string os, string region)
    {
        OS = os;
        Region = region;
        Console.WriteLine($"[SISTEMA] Creando nueva configuración física para: {os} en {region}");
    }

    public void Display(string ipAddress, double cpuUsage)
    {
        Console.WriteLine($"Server [{ipAddress}] - OS: {OS}, Region: {Region}, CPU: {cpuUsage}%");
    }
}
