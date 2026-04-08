using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddSingleton<INotifier, CloudSmsAdapter>(provider => new CloudSmsAdapter(
    new CloudSmsService(),
    "555-1234"
));
