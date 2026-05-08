var factory = new ServerConfigFactory();

for (int i = 1; i <= 1000; i++)
{
    string os = (i % 2 == 0) ? "Ubuntu 22.04" : "Windows Server 2022";
    string region = "East US";

    string ipAddress = $"10.0.0.{i}";
    double cpuUsage = new Random().NextDouble() * 100;

    // 1. Obtener la configuración compartida desde la fábrica usando 'os' y 'region'
    ServerConfiguration serverConfiguration = factory.GetConfiguration(os, region);

    // 2. Crear la 'ServerInstance' pasando la configuración obtenida
    ServerInstance serverInstance = new ServerInstance(ipAddress, serverConfiguration);

    // 3. Llamar a 'ShowStatus' para ver el resultado
    serverInstance.ShowStatus(cpuUsage);
}
